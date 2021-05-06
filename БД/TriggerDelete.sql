CREATE TRIGGER dbo.TriggerDelete
ON [dbo].[Orders] INSTEAD OF DELETE
AS
DECLARE @id int; -- сюда будем гадить для каждой строки

declare cur_for_delete cursor for select id from deleted; -- объявляем курсор 
open cur_for_delete; -- открываем
fetch cur_for_delete into  @id;   -- получаем первую строку
while @@fetch_status=0 begin -- пока есть что получать
            DELETE FROM OrdersProducts WHERE Orders_id = @id;
            DELETE FROM Orders WHERE id=@id;
            fetch cur_for_delete into  @id; -- тянем следующую строку из курсора
end
close cur_for_delete; -- не забываем закрыть
deallocate cur_for_delete
