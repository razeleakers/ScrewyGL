<h1 align="center"><img src="/images/ScrewyGL.png" alt="ScrewyGL"></h1>
<h2 align="center">ScrewyGL v2.0</h2>

## Tabla de contenidos

- [Descripcion](#descripcion)
- [Instalacion](#instalacion)
- [Uso](#uso)

## Descripcion

ScrewyGL se encarga de generar codigo C++ para dibujos que quieras crear en <a href="https://learnopengl.com/Getting-started/OpenGL">OpenGL</a>

## Instalacion

#### Clona este repositorio

```
git clone https://github.com/razeleakers/ScrewyGL.git

```
#### Dependencias

Ve a herramientas -> Administrador de paquetes NuGet -> Consola de administrador de paquetes

```
Update-Package -Reinstall

```

## Uso

Puedes hacer uso de algunos tipos de dibujos 2D que nos ofrece OpenGL:

- GL_LINES
- GL_LINE_LOOP
- GL_LINE_STRIP
- GL_TRIANGLES
- GL_TRIANGLE_STRIP
- GL_TRIANGLE_FAN
- GL_QUADS
- GL_TRIANGLE_STRIP
- GL_POLYGON

No te preocupes por el codigo, se genera todo automaticamente:

- ALL: Se mostrara todo el codigo completo para la ventana y las figuras
- ACTUAL: Solo se mostraran los metodos de todas las figuras que creaste
- LAST: Solo se mostrara el metodo de la ultima figura que creaste

<img src="/images/result.png" alt="result">

Podras agregar color y ver tus dibujos en tiempo real:

<img src="/images/example1.png" alt="example1">

Tiene soporte para que puedas crear figuras en 3D:

Teclas de movimiento: 

- W (Arriba)
- A (Izquierda)
- S (Abajo)
- D (Derecha)
- X (Acercarse)
- Z (Alejarse)

<img src="/images/example2.png" alt="example2">

##

<h4 align="center">Created by M3RFR3T</h1>
