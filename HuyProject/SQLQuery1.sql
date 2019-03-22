use  BusManager
select Bus.BSX , Bus.BusID 
select *
from Bus , Owner
Where bus.OwnerId = Owner.Id and Owner.Id = N'OW0001'
