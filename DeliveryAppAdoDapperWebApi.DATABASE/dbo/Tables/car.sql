create table cars
(
    id serial not null
        constraint cars_pkey
            primary key,
    car_status varchar(255),
    model varchar(255),
    deliveryman_id serial not null
        constraint fkaghxpod6gfwiheka29dnlckat
            references deliverymen
);