package database

import (
	"log"

	"gorm.io/driver/sqlite" // Sqlite driver based on CGO
	// "github.com/glebarez/sqlite" // Pure go SQLite driver, checkout https://github.com/glebarez/sqlite for details
	"gorm.io/gorm"
)

var DB *gorm.DB

type users struct {
	gorm.Model
	Location string `gorm:"not null"`
}

func ConnectToDB() {
	var err error
	DB, err := gorm.Open(sqlite.Open("user.db"), &gorm.Config{})

	if err != nil {
		log.Fatal("A fallado la conexion a la base de datos!")
	}

	DB.AutoMigrate(&users{})
}
