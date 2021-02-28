create table [dbo].[deliverymen]
(
    [id] int not null
        constraint deliverymen_pkey
            primary key,
    [age] integer not null,
    [name] varchar(255),
    [surname] varchar(255),
    [wages] integer not null
);