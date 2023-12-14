using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using System.Net.Http directive which will enable HttpClient.
using System.Net.Http;
//use newtonsoft to convert json to c# objects.
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using BudgetBuddy.Models;
using Newtonsoft.Json;
using System.Data;
using System.Web.UI.WebControls;
using System.Collections;
using Org.BouncyCastle.Math;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BudgetBuddy._Repositories
{
    public class MetrobankRepository
    {
        public MetrobankRepository()
        {

        }
        public static async Task<BankAccount> GetAccountFromJSONServer(string email, string account_number)
        {

            //Define your baseUrl
            string baseUrl = $"https://my-json-server.typicode.com/TimyVillarmia/metrobank/accounts?email={email}&account_number={account_number}";
            //Have your using statements within a try/catch blokc that will catch any exceptions.
            try
            {

                //We will now define your HttpClient with your first using statement which will use a IDisposable.
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        //Then get the data or content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                        using (HttpContent content = res.Content)
                        {
                            //Now assign your content to your data variable, by converting into a string using the await keyword.
                            var data = await content.ReadAsStringAsync();
                            //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                            if (data != null)
                            {
                                //Parse your data into a Array.
                                var dataArray = JArray.Parse(data);
                                //Parse your Array into a JObject.
                                var dataObj = JObject.Parse(dataArray[0].ToString());


                                //mapping out the clas
                                return new BankAccount
                                {
                                    account_number = $"{dataObj["account_number"]}",
                                    account_type = $"{dataObj["account_type"]}",
                                    current_balance = dataObj["current_balance"].Value<decimal>(),
                                    owner_name = $"{dataObj["owner_name"]}",
                                    open_date = dataObj["open_date"].Value<DateTime>(),
                                    address = $"{dataObj["address"]}",
                                    phone_number = $"{dataObj["phone_number"]}",
                                    PIN = $"{dataObj["PIN"]}",
                                    expiry_date = dataObj["expiry_date"].Value<DateTime>(),
                                    email = $"{dataObj["email"]}",
                                    external_id = $"{dataObj["external_id"]}"

                                };
                            }
                            else
                            {
                                return null;

                            }

                        }
                    }
                }



            }
            catch (Exception exception)
            {

                throw new ArgumentNullException(nameof(BankAccount));

            }


        }
        public static async Task<BankAccount> GetAccountFromJSONServer(string external_id)
        {
            if (external_id == null)
            {
                return null;
            }


            //Define your baseUrl
            string baseUrl = $"https://my-json-server.typicode.com/TimyVillarmia/metrobank/accounts?external_id={external_id}";
            //Have your using statements within a try/catch blokc that will catch any exceptions.
            try
            {

                //We will now define your HttpClient with your first using statement which will use a IDisposable.
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        //Then get the data or content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                        using (HttpContent content = res.Content)
                        {
                            //Now assign your content to your data variable, by converting into a string using the await keyword.
                            var data = await content.ReadAsStringAsync();
                            //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                            if (data != null)
                            {
                                //Parse your data into a Array.
                                var dataArray = JArray.Parse(data);
                                //Parse your Array into a JObject.
                                var dataObj = JObject.Parse(dataArray[0].ToString());


                                //mapping out the clas
                                return new BankAccount
                                {
                                    account_number = $"{dataObj["account_number"]}",
                                    account_type = $"{dataObj["account_type"]}",
                                    current_balance = dataObj["current_balance"].Value<decimal>(),
                                    owner_name = $"{dataObj["owner_name"]}",
                                    open_date = dataObj["open_date"].Value<DateTime>(),
                                    address = $"{dataObj["address"]}",
                                    phone_number = $"{dataObj["phone_number"]}",
                                    PIN = $"{dataObj["PIN"]}",
                                    expiry_date = dataObj["expiry_date"].Value<DateTime>(),
                                    email = $"{dataObj["email"]}",
                                    external_id = $"{dataObj["external_id"]}"

                                };
                            }
                            else
                            {
                                return null;

                            }

                        }
                    }
                }



            }
            catch (Exception exception)
            {

                throw new ArgumentNullException(nameof(BankAccount));

            }


        }

        public static async Task<BankAccount> PaytoVendor(string vendor_name)
        {

            //Define your baseUrl
            string baseUrl = $"https://my-json-server.typicode.com/TimyVillarmia/metrobank/accounts?owner_name={vendor_name}";
            //Have your using statements within a try/catch blokc that will catch any exceptions.
            try
            {

                //We will now define your HttpClient with your first using statement which will use a IDisposable.
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        //Then get the data or content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                        using (HttpContent content = res.Content)
                        {
                            //Now assign your content to your data variable, by converting into a string using the await keyword.
                            var data = await content.ReadAsStringAsync();
                            //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                            if (data != null)
                            {
                                //Parse your data into a Array.
                                var dataArray = JArray.Parse(data);
                                //Parse your Array into a JObject.
                                var dataObj = JObject.Parse(dataArray[0].ToString());


                                //mapping out the clas
                                return new BankAccount
                                {
                                    account_number = $"{dataObj["account_number"]}",
                                    account_type = $"{dataObj["account_type"]}",
                                    current_balance = dataObj["current_balance"].Value<decimal>(),
                                    owner_name = $"{dataObj["owner_name"]}",
                                    open_date = dataObj["open_date"].Value<DateTime>(),
                                    address = $"{dataObj["address"]}",
                                    phone_number = $"{dataObj["phone_number"]}",
                                    PIN = $"{dataObj["PIN"]}",
                                    expiry_date = dataObj["expiry_date"].Value<DateTime>(),
                                    email = $"{dataObj["email"]}",
                                    external_id = $"{dataObj["external_id"]}"

                                };
                            }
                            else
                            {
                                return null;

                            }

                        }
                    }
                }



            }
            catch (Exception exception)
            {

                throw new ArgumentNullException(nameof(BankAccount));

            }


        }

        //Now define your asynchronous method which will retrieve all your Accounts.
        public static async Task<IEnumerable<Users>> GetAllAsync()
        {
            //Define your baseUrl
            string baseUrl = "https://my-json-server.typicode.com/TimyVillarmia/metrobank/accounts";
            //Have your using statements within a try/catch blokc that will catch any exceptions.
            try
            {
                //We will now define your HttpClient with your first using statement which will use a IDisposable.
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        //Then get the data or content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                        using (HttpContent content = res.Content)
                        {
                            //Now assign your content to your data variable, by converting into a string using the await keyword.
                            var data = await content.ReadAsStringAsync();
                            //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                            if (data != null)
                            {
                                var result = JsonConvert.DeserializeObject<IEnumerable<Users>>(data);

                                return result.Where(c => c.owner_name != "Timy Villarmia");
                            }
                            else
                            {
                                MessageBox.Show("NO Data----------");
                                throw new ArgumentNullException(nameof(Users));
                            }

                        }
                    }
                }
            }
            catch (Exception exception)
            {
                throw exception;

            }
        }



        public static async Task<decimal> GetBalance(string account_number)
        {

            //Define your baseUrl
            string baseUrl = $"https://my-json-server.typicode.com/TimyVillarmia/metrobank/accounts?account_number={account_number}";
            //Have your using statements within a try/catch blokc that will catch any exceptions.
            try
            {

                //We will now define your HttpClient with your first using statement which will use a IDisposable.
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        //Then get the data or content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                        using (HttpContent content = res.Content)
                        {
                            //Now assign your content to your data variable, by converting into a string using the await keyword.
                            var data = await content.ReadAsStringAsync();
                            //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                            if (data != null)
                            {
                                //Parse your data into a Array.
                                var dataArray = JArray.Parse(data);
                                //Parse your Array into a JObject.
                                var dataObj = JObject.Parse(dataArray[0].ToString());


                                //mapping out the clas
                                return dataObj["current_balance"].Value<decimal>();
                            }
                            else
                            {
                                throw new ArgumentNullException(nameof(BankAccount));

                            }

                        }
                    }
                }



            }
            catch (Exception exception)
            {

                throw exception;

            }


        }




    }
}
