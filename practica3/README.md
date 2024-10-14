# Práctica 3 - Movimientos y Física
En esta práctica vamos a aprender conceptos sobre la física y los movimientos en Unity

### Datos del Alumno
- Igor Dragone
- alu0101469652@ull.edu.es

## Parte 1 - Experimentos de física
Vamos a crear una escena con un plano, un cubo y una esfera. Con este vamos a experimentar con diferentes configuraciones de los components Rigidbody y Collider
### 1. Cubo como objeto físico, plano y esfera no
Para configurar esta escena, hay que añadir Rigidbody únicamente al cubo. Al ejecutarla, no pasa nada, debido a que el plano y la esfera no son obejtos sujetos a la física y el cubo ya se encuentra encima del plano, luego la gravedad no le afectaría.
### 2. Cubo y esfera como objetos físicos, plano no
Para configurar esta escena, hay que añadir Rigidbody tanto al cubo como a la esfera. En este caso la esfera caerá sobre el cubo y el plano, que no se moverán. 
### 3. Cubo como objeto físico, plano no y esfera cinemática
Para configurar esta escena, hay que añadir Rigidbody tanto al cubo como a la esfera. Además, en el componente Rigidbody de la esfera debemos marcar la opción "Is Kinematic". Al ejecutarlo, no pasa nada, ya que hacer la esfera cinemática significa que no será afectada por la gravedad ni otras fuerzas físicas
### 4. Plano, cubo y esfera como objetos físicos
Para configurar esta escena, hay que añadir Rigidbody a todos los objetos de la escena. Al ejecutarlo, todos los objetos se verán sujetos a la fuerza de gravedad y caerán.
### 5. Plano, cubo y esfera como objetos físicos, esfera con 10 veces más masa que el cubo
Podemos modificar la masa de la esfera en el componente Rigidbody, directamente desde el inspector. Vamos a considerar dos variaciones para el plano:
- Plano no cinemático: en este caso, todos los objetos caerán al vacío
- Plano cinemático: en este caso, la esfera caerá sobre el cubo y, al tener una masa 10 veces mayor, va a moverlo ligermente, pero sin conseguir desplazarlo.
### 6. Plano, cubo y esfera como objetos físicos, esfera con 100 veces más masa que el cubo
Vamos a considerar dos variaciones para el plano:
- Plano no cinemático: en este caso, todos los objetos caerán al vacío
- Plano cinemático: en este caso, la esfera caerá sobre el cubo y, al tener una masa 100 veces mayor, va a desplazarlo.
### 7. Plano, cubo y esfera como objetos físicos, esfera con fricción
Podemos añadir fricción a la esfera de la siguiente forma: primero creamos un nuevo material de física, luego cambiamos los valores de fricción por los elegidos y por último le asignamos este material al componente Collider de la esfera. Al ejecutar, no podemos apreciar grandes cambios en el comportamiento de la esfera: aunque hayas aumentado su fricción, esta sigue cayendo encima del cubo y rodando por el plano.
### 8. Plano y cubo como objetos físicos, esfera como objeto no físico y con Trigger
Podemos añadir convertir la esfera en Trigger desde el componente Collider, marcando en el inspector la opción "Is Trigger". Al ejecutar, dado que la esfera no es un objeto físico, no va a pasar nada. 
### 9. Plano, cubo y esfera como objetos físicos, esfera con Trigger
En este caso la esfera caerá sobre cubo y plano, pero al ser Trigger los atravesará. 

## Parte 2 - Ejercicios