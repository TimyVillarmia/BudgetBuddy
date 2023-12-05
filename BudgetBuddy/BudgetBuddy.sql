CREATE TABLE users (
    user_id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    password_hash CHAR(64) NOT NULL,
    password_salt CHAR(64) NOT NULL,
);

CREATE TABLE user_details (
    userDetails_id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    first_name VARCHAR(64) NOT NULL,
    last_name VARCHAR (64) NOT NULL,
	user_id INT FOREIGN KEY REFERENCES users(user_id),
);



CREATE TABLE transactions(
	transaction_id INT PRIMARY KEY IDENTITY(1,1),
	sender_id VARCHAR(255) FOREIGN KEY REFERENCES users_bank_accounts(account_number),
	receiver_id VARCHAR(255) FOREIGN KEY REFERENCES users_bank_accounts(account_number),
	transaction_type VARCHAR(100) NOT NULL,
	transaction_name VARCHAR(100) NOT NULL,
	amount DECIMAL(9,2) NOT NULL,
	transaction_date DATE NOT NULL,
)


create table users_bank_accounts (
	account_number  VARCHAR(255) PRIMARY KEY NOT NULL,
	account_type VARCHAR(8) NOT NULL,
	owner_name VARCHAR(50),
	expiry_date DATE NOT NULL,
	email VARCHAR(255) FOREIGN KEY REFERENCES users(email),
);


create table Metrobank (
	account_number  VARCHAR(255) PRIMARY KEY NOT NULL,
	account_type VARCHAR(8) NOT NULL,
	current_balance DECIMAL(9,2) NOT NULL,
	owner_name VARCHAR(50),
	open_date DATE NOT NULL,
	address VARCHAR(50) NOT NULL,
	phone_number VARCHAR(50) NOT NULL,
	PIN VARCHAR(4) NOT NULL,
	expiry_date DATE NOT NULL,
	email VARCHAR(255) NOT NULL,
);


