package main

import (
	"encoding/json"
	"fmt"

	"github.com/cybercloudsys/enqueueit-go"
	"github.com/cybercloudsys/enqueueit-go/microservice"
)

type TestData struct {
	Message string
}

func main() {
	// read the microservice argument.
	arg, err := microservice.GetJobArgument()
	if err != nil {
		panic(err)
	}
	// deserialize json object to read the message
	data := &TestData{}
	json.Unmarshal([]byte(*arg), data)

	fmt.Println(data.Message)

	// connect to redis storage.
	redis, err := enqueueit.Connect(enqueueit.LoadConfiguration(nil))
	if err != nil {
		panic(err)
	}
	// enqueue a microservice
	_, err = enqueueit.Enqueue("microservice2", "Hello from second service", "services", redis)
	if err != nil {
		panic(err)
	}
}
