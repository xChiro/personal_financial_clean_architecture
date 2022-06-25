# Personal Finicial Project with Clean Architecture
Its a project with a little example of clean architecture, for more info: https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html

# Introduction

The idea of this project its explain the domain layers of The Clean Architecture (use cases and entities) making a personal finicial project.

# Project Leyers

Clen Archiceture have 4 leyers normaly, the two inner layers are the most important ones, that leyes are the Entities and the Use Cases, the entities handler the indepented bussines rules and the use cases, the application bussines rules, the use cases orchesters the entities.

# Use Case

Title: Open new account.
Primary Actor: User
Level: Actor Goal
Preconditions: N/A
Success Guarantees: Open a new account successfully. 
Data: Account Name, UserId, Person Name

Main Success Scenario:
1. User submits open a new account request.
2. Create a new account with the name, user Id and person name, with the current system date.
3. System save account
4. Returns accountId, TransactionId and zero account balance.


# Diagrams

Open Account Use Case

![Uses_Cases_and_Class_Diagrams - CD_CreateAccount](https://user-images.githubusercontent.com/3914477/175560965-e956a773-625f-4095-bce4-5e3a354d3f88.png)


# Sources

What are value objects? https://medium.com/all-you-need-is-clean-code/value-objects-d4c24115fa69
What is TDD? https://martinfowler.com/bliki/TestDrivenDevelopment.html
Clean Code/Architecture: https://www.youtube.com/playlist?list=PLmmYSbUCWJ4x1GO839azG_BBw8rkh-zOj
