CREATE Table Recepty(ReceptaID int, Nazwisko varchar(255),
Imie varchar(225),
Data_Urodzenia varchar(255)
);

Select * from Recepty

insert into Recepty (ReceptaID, Nazwisko, Imie, Data_Urodzenia) values (1, 'Kowalski' , 'Jan' , '20-09-2002');
delete from Recepty where ReceptaID=1;