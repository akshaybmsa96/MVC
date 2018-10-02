CREATE PROCEDURE GetEmp
AS
SELECT * FROM emp
GO;



CREATE proc EmpAdd
@name nvarchar(50),
@work nvarchar(50)
as
begin
insert into emp values (
@name ,
@work
)
end