CREATE TRIGGER dbo.TriggerDelete
ON [dbo].[Orders] INSTEAD OF DELETE
AS
DECLARE @id int; -- ���� ����� ������ ��� ������ ������

declare cur_for_delete cursor for select id from deleted; -- ��������� ������ 
open cur_for_delete; -- ���������
fetch cur_for_delete into  @id;   -- �������� ������ ������
while @@fetch_status=0 begin -- ���� ���� ��� ��������
            DELETE FROM OrdersProducts WHERE Orders_id = @id;
            DELETE FROM Orders WHERE id=@id;
            fetch cur_for_delete into  @id; -- ����� ��������� ������ �� �������
end
close cur_for_delete; -- �� �������� �������
deallocate cur_for_delete
