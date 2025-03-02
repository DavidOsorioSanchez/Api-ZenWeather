package initial

import (
	"log"

	"github.com/joho/godotenv"
)

func LoadEnvValues() {
	err := godotenv.Load()
	if err != nil {
		log.Fatal("Error cargando las env")
	}
}
