-- Users

insert into Users(username,hashed_password,email,created_on,last_login) 
values('Clement','defdvkjkr%esfuj','clement.caton@algosup.com',now(),now());

insert into Users(username,hashed_password,email,created_on,last_login) 
values('Ivan','rikelef565','ivan.molnar@algosup.com',now(),now());

insert into Users(username,hashed_password,email,created_on,last_login) 
values('Karine','efgkerg55ef','karine.vinette@algosup.com',now(),now());

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

insert into Rights(right_name, right_description) values('Get Prices','Get Prices');
insert into Rights(right_name, right_description) values('Fill Orders','Fill Orders (Buy or Sell)');
insert into Rights(right_name, right_description) values('Manage Settings','Manage Settings');
insert into Rights(right_name, right_description) values('Give Permissions','Give Users Permissions');
insert into Rights(right_name, right_description) values('See Orders History','See Orders History');
insert into Rights(right_name, right_description) values('Add Cryptos','Add Cryptos');


-- Add Users Roles 

insert into users_roles (user_id,role_id)
select user_v.user_id,role_v.role_id
from
(select role_id, 1 as join_id from Roles where role_name = 'Full Rights') as role_v
 inner join (select user_id, 1 as join_id from Users where username = 'Karine') as user_v on user_v.join_id = role_v.join_id;
 
 insert into users_roles (user_id,role_id)
select user_v.user_id,role_v.role_id
from
(select role_id, 1 as join_id from Roles where role_name = 'Intermediate Rights') as role_v
 inner join (select user_id, 1 as join_id from Users where username = 'Clement') as user_v on user_v.join_id = role_v.join_id;
 
 
 insert into users_roles (user_id,role_id)
select user_v.user_id,role_v.role_id
from
(select role_id, 1 as join_id from Roles where role_name = 'Limited Rights') as role_v
 inner join (select user_id, 1 as join_id from Users where username = 'Ivan') as user_v on user_v.join_id = role_v.join_id;
 
 -- Add Rights Roles 
insert into Roles_Rights (role_id,right_id)
select role_v.role_id, right_v.right_id
from
(select role_id, 1 as join_id from roles where role_name = 'Intermediate Rights') as role_v
 inner join (select right_id, 1 as join_id from rights where right_name in('Get Prices', 'See Orders History', 'Fill Orders') ) as right_v on right_v.join_id = role_v.join_id;

 















