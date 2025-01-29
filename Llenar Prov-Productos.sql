
declare @cnt Int =0;

while @cnt<100
Begin
Insert into PROV_PROD (ID,ID_PROVEEDOR,ID_PRODUCTO,PRECIO) 
Values (@cnt+2000,20,@cnt,Rand()*(1000-100)+100)
set @cnt = @cnt+1;
END