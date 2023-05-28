package main

import (
	"log"

	"github.com/cybercloudsys/enqueueit-go"
	"github.com/cybercloudsys/enqueueit-go/sqlserver"
)

func main() {
	err := enqueueit.StartServer(&sqlserver.Storage{}, nil)
	if err != nil {
		log.Panic(err)
	}
}
