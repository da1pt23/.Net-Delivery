create table [dbo].[cars]
(
    [id] int not null
        constraint cars_pkey
            primary key,
    [car_status] varchar(255),
    [model] varchar(255),
    [deliveryman_id] int not null
        constraint fkaghxpod6gfwiheka29dnlckat
            references deliverymen
);