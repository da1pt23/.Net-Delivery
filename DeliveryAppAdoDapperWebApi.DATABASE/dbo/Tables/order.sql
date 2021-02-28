create table [dbo].[orders]
(
    [Id] int not null
        constraint orders_pkey
            primary key,
    [bonus] int not null,
    [name] varchar(255),
    [payment_option] varchar(255),
    [price] int not null
);
