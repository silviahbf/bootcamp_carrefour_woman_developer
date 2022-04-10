select *
from		Clientes cli
inner join	Pedido ped
on			cli.Codigo = ped.CodigoCliente

select *
from		Clientes cli
left join	Pedido ped
on			cli.Codigo = ped.CodigoCliente

select *
from		Pedido ped
right join	Clientes cli
on			cli.Codigo = ped.CodigoCliente

select *
from		Clientes cli
left join	Pedido ped
on			cli.Codigo = ped.CodigoCliente
where		Ped.TotalPedido > 10

select *
from		Clientes cli
left join	Pedido ped
on			cli.Codigo = ped.CodigoCliente
and			ped.TotalPedido > 10

select		cli.Nome ClienteNome,
			ped.TotalPedido,
			case
				when cli.TipoPessoa = 'F' then 'Física'
				else 'Jurídica'
			end TipoPessoa
from		Clientes cli
left join	Pedido ped
on			cli.Codigo = ped.CodigoCliente
and			ped.TotalPedido > 10

select *
from PedidoItem

select *
from	PedidoItem t1
inner	join PedidoItemLog t2
on		t1.CodigoPedido = t2.CodigoPedido
and		t1.CodigoProduto = t2.CodigoProduto
inner	join StatusPedidoItem t3
on		t3.Codigo = t2.CodigoStatusPedidoItem
where	Preco between 1 and 2

select	sum(Preco * Quantidade)
from	PedidoItem t1
inner	join PedidoItemLog t2
on		t1.CodigoPedido = t2.CodigoPedido
and		t1.CodigoProduto = t2.CodigoProduto
inner	join StatusPedidoItem t3
on		t3.Codigo = t2.CodigoStatusPedidoItem

select	avg(Preco)
from	PedidoItem t1
inner	join PedidoItemLog t2
on		t1.CodigoPedido = t2.CodigoPedido
and		t1.CodigoProduto = t2.CodigoProduto
inner	join StatusPedidoItem t3
on		t3.Codigo = t2.CodigoStatusPedidoItem

select	count(Preco)
from	PedidoItem t1
inner	join PedidoItemLog t2
on		t1.CodigoPedido = t2.CodigoPedido
and		t1.CodigoProduto = t2.CodigoProduto
inner	join StatusPedidoItem t3
on		t3.Codigo = t2.CodigoStatusPedidoItem
inner	join Produtos t4

select	*
from	PedidoItem t1
inner	join PedidoItemLog t2
on		t1.CodigoPedido = t2.CodigoPedido
and		t1.CodigoProduto = t2.CodigoProduto
inner	join StatusPedidoItem t3
on		t3.Codigo = t2.CodigoStatusPedidoItem
inner	join Produtos t4
on		t4.Codigo = t2.CodigoProduto

select	t4.Codigo,
		t4.Descricao,
		t1.Preco * t1.Quantidade
from	PedidoItem t1
inner	join PedidoItemLog t2
on		t1.CodigoPedido = t2.CodigoPedido
and		t1.CodigoProduto = t2.CodigoProduto
inner	join StatusPedidoItem t3
on		t3.Codigo = t2.CodigoStatusPedidoItem
inner	join Produtos t4
on		t4.Codigo = t2.CodigoProduto

select	t4.Codigo,
		t4.Descricao,
		sum(t1.Preco * t1.Quantidade)
from	PedidoItem t1
inner	join PedidoItemLog t2
on		t1.CodigoPedido = t2.CodigoPedido
and		t1.CodigoProduto = t2.CodigoProduto
inner	join StatusPedidoItem t3
on		t3.Codigo = t2.CodigoStatusPedidoItem
inner	join Produtos t4
on		t4.Codigo = t2.CodigoProduto
group	by t4.Codigo,
		t4.Descricao
order	by 1

select	t4.Codigo,
		t4.Descricao,
		sum(t1.Preco * t1.Quantidade)
from	PedidoItem t1
inner	join PedidoItemLog t2
on		t1.CodigoPedido = t2.CodigoPedido
and		t1.CodigoProduto = t2.CodigoProduto
inner	join StatusPedidoItem t3
on		t3.Codigo = t2.CodigoStatusPedidoItem
inner	join Produtos t4
on		t4.Codigo = t2.CodigoProduto
group	by t4.Codigo,
		t4.Descricao
order	by 3 desc

select	t4.Codigo,
		t4.Descricao,
		sum(t1.Preco * t1.Quantidade) Somatoria
from	PedidoItem t1
inner	join PedidoItemLog t2
on		t1.CodigoPedido = t2.CodigoPedido
and		t1.CodigoProduto = t2.CodigoProduto
inner	join StatusPedidoItem t3
on		t3.Codigo = t2.CodigoStatusPedidoItem
inner	join Produtos t4
on		t4.Codigo = t2.CodigoProduto
group	by t4.Codigo,
		t4.Descricao
order	by Somatoria desc

select	t4.Codigo,
		t4.Descricao,
		sum(t1.Preco * t1.Quantidade) Somatoria
from	PedidoItem t1
inner	join PedidoItemLog t2
on		t1.CodigoPedido = t2.CodigoPedido
and		t1.CodigoProduto = t2.CodigoProduto
inner	join StatusPedidoItem t3
on		t3.Codigo = t2.CodigoStatusPedidoItem
inner	join Produtos t4
on		t4.Codigo = t2.CodigoProduto
group	by t4.Codigo,
		t4.Descricao
having	sum(t1.Preco * t1.Quantidade) > 10

select	*
from	Clientes cli
where	cli.Codigo not in(select codigoCliente from Pedido)

select	*
from	Clientes cli
left	join Pedido ped
on		cli.Codigo = ped.CodigoCliente
where	ped.Codigo is null

select	*
from	Clientes cli
left	join Pedido ped
on		cli.Codigo = ped.CodigoCliente
where	ped.Codigo is not null


insert Pedido values (getdate(), 0, 10, 1, 1)

select	*
from	Clientes cli
left	join Pedido ped
on		cli.Codigo = ped.CodigoCliente

select	cli.Codigo,
		cli.Nome,
		count(*)
from	Clientes cli
left	join Pedido ped
on		cli.Codigo = ped.CodigoCliente
group	by cli.Codigo,
		cli.Nome

select	cli.Codigo,
		cli.Nome,
		count(ped.Codigo)
from	Clientes cli
left	join Pedido ped
on		cli.Codigo = ped.CodigoCliente
group	by cli.Codigo,
		cli.Nome

select	*
from	Clientes cli
where	cli.Codigo not in(select codigoCliente from Pedido)

select	*
from	Clientes cli, Pedido ped, PedidoItem pedItem
where	cli.Codigo = ped.CodigoCliente
and		ped.Codigo = pedItem.CodigoPedido