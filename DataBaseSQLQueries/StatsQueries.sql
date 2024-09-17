	-- States Queries --

use BankDb;

Select SUM(Amount) from transactions where transactionType = 1;

Select Count(AccountNumber) From Accounts;

Select Sum(Balance) From Accounts;

SELECT Sum(Amount) From Transfers;

SELECT sum(Amount) from transactions;

Select count(Amount) from transactions where transactionType = 1;

Select count(Amount) from transactions where transactionType = 2;

Select count(Amount) from transactions where transactionType = 3;

select * from transactions;

select * from Accounts;

select * from Persons;


