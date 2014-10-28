/*
  Insert row for custom event registrations tile.
  Set name to 'Event Registrations' and specify
  individual constituent type. Do not display by default.
*/

declare @CHANGEAGENTID uniqueidentifier;
declare @CURRENTDATE datetime = getdate();

exec dbo.USP_CHANGEAGENT_GETORCREATECHANGEAGENT @CHANGEAGENTID
output;

if not exists(
  select 1
  from dbo.CONSTITUENTSUMMARYAVAILABLETILE
  where DATAFORMINSTANCECATALOGID = '836843d3-6380-48e0-8bd5-2477cc117f30' and CONSTITUENTTYPECODE = 0
)
begin
  insert into CONSTITUENTSUMMARYAVAILABLETILE(
    TILENAME,
    CONSTITUENTTYPECODE,
    DATAFORMINSTANCECATALOGID,
    DATEADDED,
    DATECHANGED,
    ADDEDBYID,
    CHANGEDBYID
  )
  values(
    'Event Registrations',
    0,
    '836843d3-6380-48e0-8bd5-2477cc117f30',
    @CURRENTDATE,
    @CURRENTDATE,
    @CHANGEAGENTID,
    @CHANGEAGENTID
  );
end
