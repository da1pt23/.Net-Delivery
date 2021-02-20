create table call
(
    id serial not null
        constraint calls_pkey
            primary key,
    call_status varchar(255),
    client_id serial not null
        constraint fkohrhua577ir895o9o1ibmqlbr
            references clients,
    deliveryman_id serial not null
        constraint fkr1x4m9k3tgr3vq2rkow7n58pe
            references deliverymen,
    order_id serial not null
        constraint fk5kw1qft7ko32kl2crfpvsy98c
            references orders
);