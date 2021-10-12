-- Users

insert into Users(username,hashed_password,email,created_on,last_login) 
values('Clement','defdvkjkr%esfuj','clement.caton@algosup.com',now(),now());

insert into Users(username,hashed_password,email,created_on,last_login) 
values('Ivan','rikelef565','ivan.molnar@algosup.com',now(),now());

-- Roles

insert into Roles(role_name) values('Full Rights');
insert into Roles(role_name) values('Intermediate Rights');
insert into Roles(role_name) values('Limited Rights');


