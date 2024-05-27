# Proyecto de Reproducción de Entidades

Este proyecto es una simulación de reproducción de entidades utilizando programación asincrónica en C#. El objetivo es practicar el uso de `async/await`, la clase `Random` y la gestión de tareas (`Task`) en un entorno de consola.

## Descripción

El proyecto simula la creación y reproducción de entidades (monstruos) con las siguientes características:
- **EntidadPadre**: Representa a los adultos capaces de reproducirse.
- **EntidadHija**: Representa a los hijos que envejecen con el tiempo hasta convertirse en adultos y luego pueden reproducirse.

### Funcionalidades

- **Reproducción Asincrónica**: Las entidades padres pueden reproducirse entre sí para generar entidades hijas.
- **Envejecimiento Asincrónico**: Las entidades hijas envejecen con el tiempo hasta convertirse en adultos.
- **Generación Aleatoria**: Uso de la clase `Random` para generar edades iniciales, tiempos de espera y nombres aleatorios para las entidades.

## Requisitos

- .NET Core SDK 6.0 o superior

## Configuración

1. Clona el repositorio en tu máquina local:
    ```bash
    git clone https://github.com/tu-usuario/nombre-del-repositorio.git
    ```
2. Navega al directorio del proyecto:
    ```bash
    cd nombre-del-repositorio
    ```
3. Restaura las dependencias del proyecto:
    ```bash
    dotnet restore
    ```

## Ejecución

Para ejecutar la aplicación de consola, utiliza el siguiente comando:
```bash
dotnet run
