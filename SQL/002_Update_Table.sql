-- Users

insert into Users(username,hashed_password,email,created_on,last_login) 
values('Clement','defdvkjkr%esfuj','clement.caton@algosup.com',now(),now());

insert into Users(username,hashed_password,email,created_on,last_login) 
values('Ivan','rikelef565','ivan.molnar@algosup.com',now(),now());

-- Roles

insert into Roles(role_name) values('Full Rights');
insert into Roles(role_name) values('Intermediate Rights');
insert into Roles(role_name) values('Limited Rights');


update Roles
Set Role_Description = 'Full Rights : Manage Settings, Fill Orders (Buy, Sell), Give Users permissions etc'
where role_name = 'Full Rights';

update Roles
Set Role_Description = 'Intermediate Rights : Get Prices, Fill Orders (Buy, Sell), See Orders History'
where role_name = 'Intermediate Rights';

update Roles
Set Role_Description = 'Limited Rights : Get Prices'
where role_name = 'Limited Rights';




