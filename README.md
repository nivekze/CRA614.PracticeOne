# Universidad Don Bosco - Criptografía aplicada

## Práctica Uno

El objetivo de esta práctica es diseñar y desarrollar una aplicación básica para cifrar y descifrar números. Para ello se ha desarrollado  el presente proyecto en `NET Core 3.1 (C#)`.

> Por **Kevin Omar Álvarez  Hernández**

## Diagrama UML
![Alt text](doc/PracticeOne-UMLDiagram.jpg?raw=true "Diagrama UML")

* _Cyptography_: Proyecto tipo class library que contiene lógica de los algoritmos y clase base que se detallan a continuación:
    * _Algorithm_: Clase abstracta para definir el comportamiento de los diferentes algoritmos que hereden de ella.
    * _MultiplicationAlgorithm_: Implementación básica de algoritmo de cifrado/descifrado basado en la operación multiplicación con el fin de cifrar la información. Descifrado utiliza la operación matemática inversa (División).
    * _SubtractionAlgorithm_: Implementación básica del algoritmo de cifrado/descifrado basado en la operación de resta con el fin de cifrar la información. Descifrado utiliza la operación matemática inversa (Adición).
    * _XORAlgorithm_: Implementación básica del algoritmo de cifrado/descifrado basado en la operación del operador OR exclusivo (XOR).
* CrytoTestConsole: Proyecto tipo **Consola** que hace uso de las clases dentro _Cryptography_.
* CrytoTestWinForm: Proyecto tipo **Windows Form** que hace uso de las clases dentro _Cryptography_.

## Captura de pantalla de implementaciones funcionando

### CryptoTestConsole
![Alt text](doc/CryptoTestConsole.jpg?raw=true "CryptoTestConsole")

### CryptoTestWinForm

* _SubtractionAlgorithm_: 

![Alt text](doc/CryptoTestWinForm-SubtractionAlgorithm.jpg?raw=true "CryptoTestConsole")

* _MultiplicationAlgorithm_:

![Alt text](doc/CryptoTestWinForm-MultiplicationAlgorithm.jpg?raw=true "CryptoTestWinForm Multiplication Algorithm")

* _XORAlgorithm_:

![Alt text](doc/CryptoTestWinForm-XORAlgorithm.jpg?raw=true "CryptoTestConsole")