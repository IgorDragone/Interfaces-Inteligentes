# Práctica 2 - C# Scripts
En esta práctica vamos a adentrarnos en el mundo de los scripts para Unity. El objetivo es el de familiarizarnos con C# a través de 8 ejercicios diferentes.

### Datos del Alumno
- Igor Dragone
- alu0101469652@ull.edu.es

### Ejercicio 1
En el primer ejercicio cambiamos el color de un objeto por uno aleatorio en un intervalo de tiempo definido por la variable `frameDelay`. Para que esta pueda ser modificada en el inspector, la hicimos pública. Para cambiar el color, usamos el componente `Renderer`de los objetos, con su propiedad `Material` que a su vez contiene a la propiedad `color`. Para el factor aleatorio usamos la clase `Random` de Unity, con la propiedad estático `value`, que devuelve un flotante entre 0 y 1.
### Ejercicio 2
En el segundo ejercicio creamos un plano con un cubo, una esfera y un cilindro, le asignamos un color a cada uno de estos e imprimimos por consola el nombre del objeto. Para imprimir el nombre usamos la propiedad `name`de `GameObject`. Para asignar un color a los objetos, primero creamos un Material, luego le asignamos un color en el inspector y por último lo asignamos al objeto
### Ejercicio 3
En el tercer ejercicio trabajamos con los vectores3D de C#. La clase `Vector3`contiene métodos estáticos como `Angle`(te dice el ángulo que forman 2 vectores) y `Distance`(la distancia entre 2 vectores), además de propiedades como `y`, para la altura y `magnitude`. Creamos los vectores de forma pública para poder darle valores en el inspector
### Ejercicio 4
En el cuarto ejercicio hacemos uso de la `GUI`para mostrar en pantalla el vector con la posición de la esfera. Para acceder a la posición de esta usamos `transform.position`.
### Ejercicio 5
En el quinto ejercicio mostramos por consola la distancia de la esfera con los otros objetos. Para ello hacemos uso de la función `FindWithTag` que nos permite encontrar los objetos por su etiqueta. Bastarà con asignar al cubo y al cilindro los tags de `Cube`y `Cylinder`respectivamente para encontrarlos. La distancia la calculamos con el método `Distance`, mencionado previamente y la propiedad `position` de cada objeto.
### Ejercicio 6
En el sexto ejercicio aprendemos dos nuevas mecánicas: los objetos invisibles y leer el input por teclado. Nuestro objetivo es mover tres objetos con un desplazamiento insertado en el inspector, y que esto ocurra solo si pulsamos la tecla espacio. Usamos el objeto invisible para asignarle el script que modifique la posición, sacando el desplazamiento de la variable pública `displacement`. Para leer por teclado, usamos el método `GetKeyDown`de la clase `Input`.
### Ejercicio 7
En el séptimo ejercicio queremos cambiar colores a objetos dependiendo de la tecla que pulsemos. Aquí volvemos a usar `Input.GetKwyDown` para detectar que tecla pulsamos (C para cilindro, flecha arriba para cubo). Para acceder al color de un objeto y poder cambiarlo volvemos a usar `GetComponent<Renderer>().material.color`. En cuanto al color en sí, optamos por decidirlo directamente en el inspector
### Ejercicio 8
En el octavo ejercicio creamos 5 esferas, dividiendolas en 2 grupos: 2 esferas serán del tipo 1(tag: T1Sphere), y los otras serán del tipo 2(tag: T2Sphere). El objetivo es el de identificar la esfera de tipo 2 más lejana y la más cercana a un cubo nuevo para cambiarle el color y aumentar la altura respectivamente. Para ello hacemos uso del método `FindGameObjectsWithTag`, que nos devuelve un vector con todos los objetos con ese tag. Tanto el incremento de altura como el color son variables públicas para poder ser cambiadas en el inspector. 

### Gif da la Ejecución
![gif](Pr2II.gif)