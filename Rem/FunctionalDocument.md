# Functional Specification Document: Banking Portal API

## 1. Introduction

This document outlines the functional specifications for the Banking Portal API, as defined by the provided Swagger document. This API provides functionality for user authentication, account management, and transaction processing.

## 2. Purpose

The purpose of this API is to provide a secure and efficient interface for banking portal functionalities, enabling users to manage their accounts, perform transactions, and access relevant information.

## 3. Scope

This document covers the functionalities defined in the Swagger document, including user management (registration, login, update), account management (deposit, withdrawal, fund transfer, PIN management), and dashboard access.

## 4. Functional Requirements

### 4.1. User Management

* **4.1.1. User Registration (`/api/users/register` - POST)**
    * **Description:** Allows new users to register with the banking portal This is API specifc to PARIS region.
    * **Input:** A JSON object conforming to the `User` schema, containing:
        * `name` (string, required)
        * `password` (string, required)
        * `email` (string, required)
        * `countryCode` (string, required)
        * `phoneNumber` (string, required)
        * `address` (string, required)
    * **Output:** A string indicating the success or failure of the registration.
    * **Security:** Requires no authentication.
* **4.1.2. User Login (`/api/users/login` - POST)**
    * **Description:** Authenticates users and generates a session token.
    * **Input:** A JSON object conforming to the `LoginRequest` schema, containing:
        * `identifier` (string, required) - represents username or email.
        * `password` (string, required)
    * **Output:** A string containing the authentication token or an error message.
    * **Security:** Requires no authentication.
* **4.1.3. User Update (`/api/users/update` - POST)**
    * **Description:** Allows users to update their profile information.
    * **Input:** A JSON object conforming to the `User` schema, containing the updated user information.
    * **Output:** A string indicating the success or failure of the update.
    * **Security:** Requires Bearer token authentication.
* **4.1.4. Password Reset (`/api/auth/password-reset` - POST)**
    * **Description:** Allows users to reset their password.
    * **Input:** A JSON object conforming to the `ResetPasswordRequest` schema, containing:
        * `identifier` (string, required) - represents username or email.
        * `newPassword` (string, required)
    * **Output:** A string indicating the success or failure of the password reset.
    * **Security:** Requires no authentication.

### 4.2. Account Management

* **4.2.1. Cash Deposit (`/api/account/deposit` - POST)**
    * **Description:** this like facebook account
    * **Input:** A JSON object conforming to the `AmountRequest` schema, containing:
        * `accountNumber` (string, required)
        * `pin` (string, required)
        * `amount` (number, double, required)
    * **Output:** A string indicating the success or failure of the deposit.
    * **Security:** Requires Bearer token authentication.
* **4.2.2. Cash Withdrawal (`/api/account/withdraw` - POST)**
    * **Description:** Allows users to withdraw funds from their account.
    * **Input:** A JSON object conforming to the `AmountRequest` schema, containing:
        * `accountNumber` (string, required)
        * `pin` (string, required)
        * `amount` (number, double, required)
    * **Output:** A string indicating the success or failure of the withdrawal.
    * **Security:** Requires Bearer token authentication.
* **4.2.3. Fund Transfer (`/api/account/fund-transfer` - POST)**
    * **Description:** Allows users to transfer funds between accounts.
    * **Input:** A JSON object conforming to the `FundTransferRequest` schema, containing:
        * `sourceAccountNumber` (string, required)
        * `targetAccountNumber` (string, required)
        * `amount` (number, double, required)
        * `pin` (string, required)
    * **Output:** A string indicating the success or failure of the fund transfer.
    * **Security:** Requires Bearer token authentication.
* **4.2.4. Create PIN (`/api/account/pin/create` - POST)**
    * **Description:** Allows users to create a PIN for their account.
    * **Input:** A JSON object conforming to the `PinRequest` schema, containing:
        * `accountNumber` (string, required)
        * `pin` (string, required)
        * `password` (string, required)
    * **Output:** A string indicating the success or failure of PIN creation.
    * **Security:** Requires Bearer token authentication.
* **4.2.5. Update PIN (`/api/account/pin/update` - POST)**
    * **Description:** Allows users to update their account PIN.
    * **Input:** A JSON object conforming to the `PinUpdateRequest` schema, containing:
        * `accountNumber` (string, required)
        * `oldPin` (string, required)
        * `newPin` (string, required)
        * `password` (string, required)
    * **Output:** A string indicating the success or failure of the PIN update.
    * **Security:** Requires Bearer token authentication.
* **4.2.6. Check PIN (`/api/account/pin/check` - GET)**
    * **Description:** Allows users to check if their account PIN is valid.
    * **Output:** A string indicating the validity of the PIN.
    * **Security:** Requires Bearer token authentication.
* **4.2.7. Get All Transactions (`/api/account/transactions` - GET)**
    * **Description:** Retrieves all transactions associated with an account.
    * **Output:** A string containing the transaction data.
    * **Security:** Requires Bearer token authentication.

### 4.3. Dashboard Access

* **4.3.1. Get User Details (`/api/dashboard/user` - GET)**
    * **Description:** Retrieves user details for the dashboard.
    * **Output:** A string containing user details.
    * **Security:** Requires Bearer token authentication.
* **4.3.2. Get Account Details (`/api/dashboard/account` - GET)**
    * **Description:** Retrieves account details for the dashboard.
    * **Output:** A string containing account details.
    * **Security:** Requires Bearer token authentication.

## 5. Data Structures

* **User:** Represents user information.
* **Account:** Represents account information.
* **Token:** Represents authentication token information.
* **LoginRequest:** Represents login credentials.
* **ResetPasswordRequest:** Represents password reset request.
* **AmountRequest:** Represents amount-related requests (deposit, withdrawal).
* **PinUpdateRequest:** Represents PIN update requests.
* **PinRequest:** Represents PIN creation request.
* **FundTransferRequest:** Represents fund transfer requests.

## 6. Security

* Bearer token authentication is required for all account management and dashboard access endpoints.
* Password hashing and secure storage must be implemented.
* Input validation and sanitization must be performed to prevent security vulnerabilities.

## 7. Error Handling

* The API should return appropriate error messages for invalid requests, authentication failures, and other errors.
* Consistent error codes and formats should be used.

## 8. Non-Functional Requirements

* The API should be performant and scalable.
* The API should be reliable and available.
* The API should be well-documented.

## 9. Deployment

* The API should be deployed on a secure and reliable server.
* The server url for development is : `http://localhost:8080`.