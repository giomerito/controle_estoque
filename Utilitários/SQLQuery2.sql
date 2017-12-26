CREATE trigger DecrementaEstoqueItensCompra on itenscompra
for delete
as
BEGIN
DECLARE 
@qtde float,
@codigo integer

declare CURSOR_PROD cursor for

SELECT pro_cod, itc_qtde FROM deleted

open CURSOR_PROD

fetch next from CURSOR_PROD into @codigo, @qtde

while @@fetch_status = 0

begin

update produto set pro_qtde = pro_qtde - @qtde where produto.pro_cod = @codigo

fetch next from CURSOR_PROD into @codigo, @qtde

end

close CURSOR_PRODdeallocate CURSOR_PROD

end
go


CREATE trigger IncrementaEstoqueItensCompra on itenscompra
for insert
as
BEGIN
DECLARE @qtde float,
@codigo integer

declare CURSOR_PROD cursor for

SELECT pro_cod, itc_qtde FROM inserted

open CURSOR_PROD

fetch next from CURSOR_PROD into @codigo, @qtde

while @@fetch_status = 0

begin

update produto set pro_qtde = pro_qtde + @qtde where produto.pro_cod = @codigo

fetch next from CURSOR_PROD into @codigo, @qtde

end

close CURSOR_PRODdeallocate CURSOR_PROD

end
go