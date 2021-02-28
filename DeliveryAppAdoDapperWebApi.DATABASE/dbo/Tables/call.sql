create table [dbo].[Calls]
(
    [Id] INT not null constraint calls_pkey primary key,
    [call_status] varchar(255),
    [client_id] int not null,
    [deliveryman_id] int not null,
    [order_id] int not null
);