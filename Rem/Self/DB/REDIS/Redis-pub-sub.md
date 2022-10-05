
Redis can be used as Pub Sub as a Messaging System

Compare to other message bus systems (Ex: RabbitMQ, Kafka) Redis pub/sub having some limitation.

Those message bus are able to store the message and replay of an old messages if required.
But In Redis if here are no subscribers up then it will not receive those messages.

Redis can be used for non critical business scenarios or very small applicaitons
