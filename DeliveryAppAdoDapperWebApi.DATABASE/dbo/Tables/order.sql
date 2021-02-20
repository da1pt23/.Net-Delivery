create table order
(
    id serial not null
        constraint orders_pkey
            primary key,
    bonus serial not null,
    name varchar(255),
    payment_option varchar(255),
    price serial not null
);
