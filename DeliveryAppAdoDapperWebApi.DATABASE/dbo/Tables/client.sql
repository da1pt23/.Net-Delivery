create table clients
(
    id serial not null
        constraint clients_pkey
            primary key,
    address varchar(255),
    name varchar(255),
    phone_number varchar(255)
);