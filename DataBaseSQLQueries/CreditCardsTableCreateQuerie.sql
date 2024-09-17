use bankDB;
CREATE TABLE CreaditsCard
(
	CardID int not null primary key,
	CreaditCardNumber nvarchar(50) not null,
	AccountNumber int not null,
	ActivationStatus bit not null,
	FOREIGN KEY (AccountNumber) REFERENCES Accounts(AccountNumber)
);
