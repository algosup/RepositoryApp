CREATE TABLE Users (
	user_id serial PRIMARY KEY,
	username VARCHAR ( 100 ) UNIQUE NOT NULL,
	hashed_password VARCHAR ( 250 ) NOT NULL,
	email VARCHAR ( 255 ) UNIQUE NOT NULL,
	created_on TIMESTAMP NOT NULL,
    last_login TIMESTAMP 
);

CREATE TABLE Roles(
   role_id serial PRIMARY KEY,
   role_name VARCHAR (255) UNIQUE NOT NULL
);


CREATE TABLE Rights(
   right_id serial PRIMARY KEY,
   right_name VARCHAR (255) UNIQUE NOT NULL  
);


CREATE TABLE Users_Roles (
  user_id INT NOT NULL,
  role_id INT NOT NULL,  
  PRIMARY KEY (user_id, role_id),
  FOREIGN KEY (user_id) REFERENCES Users (user_id),
  FOREIGN KEY (role_id) REFERENCES Roles (role_id)  
);


CREATE TABLE Roles_Rights (  
  role_id INT NOT NULL,  
  right_id INT NOT NULL,  
  is_active VARCHAR (1) NOT NULL DEFAULT 'Y',
  PRIMARY KEY (role_id,right_id),  
  FOREIGN KEY (role_id) REFERENCES Roles (role_id),
  FOREIGN KEY (right_id) REFERENCES Rights (right_id)
);

--- 

Alter table Roles add column role_description VARCHAR (2000);

-- To Add a description column on Rights table, we drop the table and create it again

alter table roles_rights drop constraint roles_rights_right_id_fkey;

drop table Rights;

CREATE TABLE Rights(
   right_id serial PRIMARY KEY,
   right_name VARCHAR (255) UNIQUE NOT NULL,
   right_description VARCHAR (2000)
);

ALTER Table Roles_Rights ADD FOREIGN KEY (right_id) REFERENCES Rights (right_id);












