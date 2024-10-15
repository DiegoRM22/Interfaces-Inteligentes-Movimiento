# Situaciones

## Situación 1
En esta situación, a la esfera y el plano no les afecta la gravedad, pues no tienen componente `Rigidbody`, mientras que al cubo sí. Además, gracias a que tanto el plano como el cubo tienen componente de `Collider`, el cubo no se cae, se mantiene encima del plano.

![Situación 1](Gif/Situacion1.gif)

## Situación 2
Idem a la situación anterior, pero ahora la esfera tiene el mismo comportamiento que el cubo, llegando a caerse del plano.

![Situación 2](Gif/Situacion2.gif)

## Situación 3
El cubo sigue teniendo el mismo comportamiento. Sin embargo, la esfera ya no cae como en la situación anterior, pues se ha activado el `IsKinematic`, por lo que su `Rigidbody` no es movido por el motor de físicas.

![Situación 3](Gif/Situacion3.gif)

## Situación 4
En este caso, el motor de físicas actúa sobre todos los componentes y ninguno es cinemático, por lo que todos caen.

![Situación 4](Gif/Situacion4.gif)

## Situación 5
Pasa lo mismo, todos los objetos caen, sin notarse el aumento de masa. Si el plano fuera cinemático y no cayera, se notaría mejor.

![Situación 5](Gif/Situacion5.gif)

## Situación 6
Idem al anterior pero con 100.

![Situación 6](Gif/Situacion6.gif)

## Situación 7
Si el plano no se pone como cinemático, ocurre lo mismo. En otro caso, ocurre lo mismo que en la situación 2 pero sin que la esfera llegue a caerse del plano gracias a la fricción que la frena.

![Situación 7](Gif/Situacion7.gif)

## Situación 8
La esfera no cae, ya que no es objeto físico.

![Situación 8](Gif/Situacion8.gif)

## Situación 9
La esfera cae y, como es `trigger`, traspasa el plano.

![Situación 9](Gif/Situacion9.gif)

# Ejercicios

## Ejercicio 1
![Ejercicio 1](Gif/Ejercicio_1.gif)

## Ejercicio 2
![Ejercicio 2](Gif/Ejercicio2.gif)

## Ejercicio 3
a) Aumenta por dos el espacio recorrido en cada frame.  
b) Ocurre lo mismo que en la situación anterior, ya que al desplazar el cubo se multiplica la dirección del vector por la velocidad (y por `Time.deltaTime`).  
c) Se disminuye el recorrido que realiza en cada frame.  
d) El movimiento del cubo comienza desde el aire.  
e) Al aplicar el movimiento relativo al sistema de referencia local, el objeto se mueve hacia donde esté mirando. Sin embargo, al aplicar el global, este cambia su posición con respecto a los ejes del mundo.

![Ejercicio 3](Gif/Ejercicio3.gif)

## Ejercicio 4
![Ejercicio 4](Gif/Ejercicio4.gif)

## Ejercicio 6
![Ejercicio 6](Gif/Ejercicio6.gif)

## Ejercicio 7
![Ejercicio 7](Gif/Ejercicio7.gif)

## Ejercicio 8
![Ejercicio 8](Gif/Ejercicio8.gif)

## Ejercicio 9
![Ejercicio 9](Gif/Ejercicio9.gif)

## Ejercicio 12
![Ejercicio 12](Gif/Ejercicio12.gif)
