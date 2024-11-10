# Task: Design an Order and Product Management System

## Objective

The goal is to design and implement a system that manages products and
orders using _CQRS and event-driven architecture_. The system should be _loosely coupled_ even if the monolith architecture is chosen. Your focus should be on how the system is designed, with implementation being secondary.

## Task Requirements:

1. Architecture:
   a. Design either a **monolithic** or **microservices** architecture with two main services:

   - Order Service
   - Product Service

   > [!NOTE]  
   > I was able to only make some progress on the **Product Service** and did not get far enough to touch **Order Service** in due time.

   > [!Important]
   > I began setting the project up, intending to go for **microservices** but _Docker_ failed to run on my laptop and therefore I couldn't get far enough to create **images** and setup a **RabbitMQ** message queue to connect services together in the microservices fashion.

   b. The system should ensure that services are _not tightly coupled_ even if a monolithic design is chosen.\
   c. The architecture should support _event-driven communication_ between
   services using **RabbitMQ**.

   > [!CAUTION]
   > Step remained incomplete by the end of time. Did not begin working on **RabbitMQ** for the project within the time limit

   d. Implement _CQRS (Command Query Responsibility Segregation)_ to
   separate _read_ and _write_ operations.

   > [!CAUTION] > **CQRS** is a foreign concept for me, and although I tried to learn and implement **CQRS** within the given time limit, it did not work out in the end.

2. Services:
   a. Product Service:

   - Manages the product catalogue.
   - Read requests: _20k requests per day_.
   - Write requests: _1k requests per day_.

   > [!CAUTION] > Final solution does not contain any complete features from the product services.

   b. Order Service:

   - Manages customer orders.
   - Read and write requests: _1k requests per day_.

   > [!CAUTION]
   > Final solution does not contain any complete features from the order service.

   c. Services should use **RabbitMQ** for communicating **events** (e.g., when a new order is placed or when a product is updated).

   > [!CAUTION]
   > Failed to install **RabbitMQ** in due time and use it.

3. Database:
   a. Use **MSSQL** as the primary database.

   > [!NOTE]
   > Attempted to use a docker image for the **MySQL** database.

   b. Each service (if using microservices) should have its own database schema (for data isolation).

   > [!NOTE]
   > Planned for it but didn't get to it.

   c. Implement proper indexing and performance considerations, especially for the high-read operations in the Product Service.

   > [!CAUTION]
   > Didn't bother to ramp up the optimization to the database due to the noticed shortage of time.

4. Core Functionalities:
   a. Product Service:

   - Add new products (write).
   - Update product details (write).
   - Fetch product details (read).
   - Fetch a list of products (read).

   b. Order Service:

   - Place an order (write).
   - Update order status (write).
   - Fetch order details (read).
   - Fetch a list of orders (read).

   > [!CAUTION]
   > Wasn't able to finish any portion of it without facing any syntax errors.

5. Event-Driven Architecture:  
   a. When an **order is placed**, an event should be published (using RabbitMQ) to inform the Product Service to update inventory.
   b. When a **product is updated**, an event should be published to inform other systems (e.g., for caching or analytics).

   > [!CAUTION]
   > Didn't get far enough to install and use **RabbitMQ** for the project

6. Testing:
   a. Write **unit tests** for core functionalities in both services.

   b. If possible, include basic **integration tests** that simulate real-world scenarios (e.g., an order is placed, and the product stock is updated).

   c. Ensure your tests follow best practices and provide adequate code
   coverage.

   > [!CAUTION]
   > Didn't write any test code at all (due to shortage of time)

7. Non-Functional Requirements:
   a. Ensure the system is designed to handle the given load (_20k reads_, _1k writes_ for **Product**; _1k reads/writes_ for **Order**).

   b. Consider **scalability**, especially for the **Product Service** due to the high read volume.

   c. Document your design decisions and explain how the architecture would
   scale if the request load increases.

   > [!CAUTION]
   > Optimization (such as load balancing) have not been implemented.

## Evaluation Criteria:

- System Design: The candidate’s ability to design a system that meets the given requirements while maintaining loose coupling.
- CQRS and Event-Driven Implementation: How well the candidate implements
  CQRS and integrates event-driven communication using RabbitMQ.
- Code Quality: The readability, structure, and organization of the code, including testing practices.
- Scalability Considerations: How the candidate plans for system scalability given the load.
- Testing: The completeness and quality of the unit and integration tests.
