Explicaci�n uso de patrones

Creaci�n de 3 tipos de AI

	Para este se utliz� 3 tipos de patrones de creaci�n (Factory, Pool, Singleton)

	Se utiliza factory para que a demanda del enemySpawner cree 3 distintos tipos de enemigos,
	los cuales agarra de una pool.
	
	Como el enunciado dice "Las instancias de AI creadas tampoco deben instanciarse y destruirse continuamente"
	quise utilizar este patr�n para siempre tener un n�mero de elementos que estar�n activ�ndose y desactiv�ndose 
	seg�n una implementaci�n y evitar lo del enunciado. (Para las diferentes formas de enemigo, fijarse en el enum)

	El patr�n Singlet�n se utiliz� para controlar la existencia de pools de la f�bica, dejando unicamente una pool
	para solo de la f�brica y permitir una manipulaci�n m�s sencilla de c�digo. 

Creaci�n de BALAS

	Se utiliza nuevamente pool por el mismo problema que se presenta respecto a las instancias de AI, es decir
	evitar la instanciaci�n y destrucci�n constante de un objeto.
