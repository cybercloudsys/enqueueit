package main

import (
	"fmt"

	"github.com/cybercloudsys/enqueueit-go/microservice"
)

func main() {
	arg, err := microservice.GetJobArgument()
	if err == nil {
		fmt.Println(*arg)
	} else {
		panic(err)
	}
}
