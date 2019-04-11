Explicación uso de patrones

Creación de 3 tipos de AI

	Para este se utlizó 3 tipos de patrones de creación (Factory, Pool, Singleton)

	Se utiliza factory para que a demanda del enemySpawner cree 3 distintos tipos de enemigos,
	los cuales agarra de una pool.
	
	Como el enunciado dice "Las instancias de AI creadas tampoco deben instanciarse y destruirse continuamente"
	quise utilizar este patrón para siempre tener un número de elementos que estarán activándose y desactivándose 
	según una implementación y evitar lo del enunciado. (Para las diferentes formas de enemigo, fijarse en el enum)

	El patrón Singletón se utilizó para controlar la existencia de pools de la fábica, dejando unicamente una pool
	para solo de la fábrica y permitir una manipulación más sencilla de código. 

Creación de BALAS

	Se utiliza nuevamente pool por el mismo problema que se presenta respecto a las instancias de AI, es decir
	evitar la instanciación y destrucción constante de un objeto.
