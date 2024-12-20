# Práctica 4 - Eventos
En esta práctica vamos a aprender conceptos sobre los eventos en Unity, a través de 9 ejercicios.

### Datos del Alumno
- Igor Dragone
- alu0101469652@ull.edu.es

### Ejercicio 1
En este ejercicio necesitamos una escena con un cubo físico, un cílindro y cinco esferas (2 de tipo 1 y 3 de tipo 2). El objetivo es conseguir que cuando el cubo colisione con el cilindro, las esferas de tipo 1 se dirijan hacia una de las esferas de tipo 2 y las esferas de tipo 2 se desplacen hacia el cilindro. Empezamos, con el cubo: lo hacemos cinemático y le asignamos un script que permita moverle con las flechas. Pasamos al cílindro, que será nuestro Notificador: lo hacemos trigger y le asigamos un script que tenga el método `OnTriggerEnter`, que a su vez lance el evento `OnColisionWithCube`, que consegumos a través del delegado. Ahora es el momento de los suscriptores, es decir, las esferas. Para estas vamos a usar un script con corrutinas, pues estas permiten distribuir la ejecución del código durante varios frames (alternativa al Update). En primer lugar subscribimos los callbacks al notificador, con `CylinderTrigger.OnColisionWithCube += MoveToObject;`. MoveObject es el callback y varía dependiendo del tipo de la esfera: para las del tipo 1 (de color verde), hará que estas se muevan hacia una esfera de tipo 2 a elegir; para las del tipo 2 (de color rojo), hará que estas se muevan hacia el cilindro. Ejecución:
![1](./img/ej1-pr4.gif)

### Ejercicio 2
En este ejercicio simplemente sustituimos las esferas con arañas y el cilindro con el huevo. Para ello importamos el asset Fuga spiders al proyecto y elegimos las arañas verdes y azules para el tipo 1 y las arañas rojas para el tipo 2.
![2](./img/ej2.png)

### Ejercicio 3 y 9
En este ejercicio tenemos una escena 5 tipos de objetos físicos: un cubo cinemático, arañas tipo 1 y 2 y huevos tipo 1 y 2. Queremos obtener los siguientes comportamientos:
- Cuando el cubo toca una araña del tipo 2, las arañas en el grupo 1 se acercan a un objeto seleccionado. En este caso seleccioné un huevo de tipo 1. Para conseguir este escenario, he configurado el cubo como notificador y las arañas de tipo 1 como subscriptores, usando otra vez corrutinas para los callbacks.
- Cuando el cubo toca una araña del tipo 1, las arañas del grupo 1 se dirigen hacia los huevos del grupo 2 que serán objetos físico. Si alguna araña colisiona con uno de ellos debe cambiar de color. Repetimos lo mismo que en el escenario anterior. Para cambiar el color, usamos el método `GetComponentInChildren<SkinnedMeshRenderer>()`

Además, para evitar repetir las configuraciones en todos los objetos 3D, he creado un prefab para cada objeto. 

![3](./img/ej3-pr4.gif)

### Ejercicio 4
En este ejercicio vamos a tener que elegir un objeto de referencia (elegí un huevo de tipo 1). Cuando el cubo se acerque a este objeto, deben suceder dos cosas:
- Las arañas del grupo 1 se teletransportan a un huevo objetivo (elegí un huevo de tipo 2). El cubo es el notificador y las arañas de tipo 1 los suscriptores
- Las arañas del grupo 2 se orientan hacia un objeto ubicado en la escena con ese propósito (elegí otro huevo de tipo 2). El cubo es el notificador y las arañas de tipo 2 los suscriptores.

![4](./img/ej4.gif)

### Ejercicio 5
En este ejercicio vamos a implementar 2 nuevas mecánicas:
- Recolección de huevos. Ahora, cuando una araña colisione con un huevo, este desaparecerá para simular la recolección.
- Sistema de puntuación. Cuando una araña de tipo 1 recolecte un huevo, el jugador ganará 5 puntos, y cuando lo haga una de tipo 2, ganará 10. Las arañas son los notificadores y el sistema de puntuación, que se va incrementando, es el subscriptor.

De esta forma hemos creado un minijuego, que consiste en hacer mover las arañas para que vayan a recolectar huevos. En mi caso, para mover las arañas de tipo 1 hay que colsionar con ellas, mientras que para mover a las arañas de tipo 2, habría que acercarse al cilindro del medio.

![5](./img/ej5.gif)

### Ejercicio 6
En vez de visualizar los puntos por consola, vamos a verlos en la pantalla a través de una UI. Para ello creamos, un `Canvas` (GameObject > UI > Canvas), le agregamos un objeto de texto (Text - TextMeshPro) con la frase "Score: 0" y modificamos el script ScoreManager.cs para que lo actualice.

![6](./img/ej6.png)

### Ejercicio 7
Añadimos otro texto que nos indica las recomopensas que hemos obtenido en el juego (en este caso, estrellas). Cada 100 puntos conseguidos, obtenemos una estrella.

![7](./img/ej7.gif)

### Ejercicio 8
Para este ejercicio he decidio crear un minijuego que consiste en lo siguiente: el jugador empieza con 100 de vida y es perseguido por las arañas. Cada vez que una araña colisione con él, pierde 10 puntos de vida. Cuando la vida llega a 0, el juego se acaba. 
He usado elementos como el canvas para representar la vida del jugador y eventos, en los que el script encargado de detectar colisiones es el notificador y el script encargado de manejar la salud del jugador es el suscriptor.

![8](./img/ej8.gif)

![8.1](./img/ej8.png)
