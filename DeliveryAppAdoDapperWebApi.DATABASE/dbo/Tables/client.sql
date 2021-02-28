create table [dbo].[clients]
(
    [id] int not null
        constraint clients_pkey
            primary key,
    [address] varchar(255),
    [name] varchar(255),
    [phone_number] varchar(255)
);