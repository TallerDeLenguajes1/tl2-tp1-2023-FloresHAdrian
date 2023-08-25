

*¿Cuál de estas relaciones considera que se realiza por composición y cuál por
agregación?
	Cadete - Cadeteria: Agregacion
	Cadete - Pedido: Agregacion
	Pedido - Cliente: Composicion

*¿Qué métodos considera que debería tener la clase Cadetería y la clase Cadete?
	Cadeteria:
		AgregarPedido(cliente, cadete, pedido)
		VerListadoCadetes()
        CrearPedido()
        AgregarCadete()
        BorrarCadete()
		EliminarCliente()
		Informe()
		
	Cadete:
		AgregarPedido();
		BorrarPedido()
		CambiarEstadoPedido()
		CantidadPedidos()
		

*Teniendo en cuenta los principios de abstracción y ocultamiento, que atributos,
propiedades y métodos deberían ser públicos y cuáles privados.
    Cadeteria:
        privado: Listado de Cadetes 
        publico: Nombre, Telefono
    
    Cadete:
        privado: Listado de pedidos
        publics:
    
    Cliente:
        privado: 
        publico:
    
    Pedido:


*¿Cómo diseñaría los constructores de cada una de las clases?

*¿Se le ocurre otra forma que podría haberse realizado el diseño de clases?