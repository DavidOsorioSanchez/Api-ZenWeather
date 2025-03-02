package main

import (
	"Api-ZenWeather/MainApp/database"
	"Api-ZenWeather/MainApp/initial"

	"github.com/gin-gonic/gin"
)

// To run this file with CompileDaemon, use the following command in your terminal:
// CompileDaemon -command="./MainApp"
func init() {
	initial.LoadEnvValues()
	database.ConnectToDB()
}

func main() {
	root := gin.Default() //inicializa la aplicacion con Gin

	// Ruta de prueba
	root.GET("/", func(context *gin.Context) {
		context.JSON(200, gin.H{ //este es un JSON de respuesta
			"message": "pong",
		})
	})
	root.Run(":8080") //este es el puerto en el que se ejecutara la aplicacion
}
