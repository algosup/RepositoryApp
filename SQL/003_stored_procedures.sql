create or replace procedure get_roles_per_user(INOUT _val text DEFAULT null)
language plpgsql    
as $$
begin
    
	select u.username, u.email, r.role_name  "role name", r.role_description "role description"
	from users u
	inner join users_roles ur on ur.user_id = u.user_id
	inner join roles r on r.role_id = ur.role_id
	into _val;
	
end;$$

call get_roles_per_user();