# Project Management

[TOC]



## Tasks

### Documentation

#### Event Tables

- [ ] Event Table Admin
- [ ] Event Table Customer

#### Use Case Descriptions

- [ ] Use Case Descriptions Customer
- [ ] Use Case Descriptions Admin

#### Test Plan

### Diagrams

#### Use Case Diagrams

##### Admin use case diagram

- [ ] Admin use case diagram

##### Customer use case diagram

- [ ] Customer use case diagram

#### Sequence Diagrams

##### Admin Sequence Diagrams

- [ ] Add Admin sequence diagrams

##### Customer Sequence Diagrams

- [ ] Add Customer sequence diagrams

#### Class Diagram

- [ ] Add Class Diagram

#### ERD

- [ ] Add ERD

### Implementation

#### Prototype

##### Setup

- [x] Add Gulp
- [x] Setup Sass with Bootstrap
- [ ] Add Masterpages
- [ ] Add Test Project
- [ ] Add Admin Portal
- [ ] Add class library

##### Customer site pages

- [ ] Home page
- [ ] Register/Login page
- [ ] Single item page
- [ ] Categories page
- [ ] Checkout page
- [ ] Account page
- [ ] Orders page
- [ ] Single order page
- [ ] Customer details page

##### Admin site pages

- [ ] First time / Startup page
- [ ] Login page
- [ ] Items page
- [ ] Single item page
- [ ] Orders page
- [ ] Review page

## Event Tables

### Admin - Event table

| Subject | Verb                  | Object | Response                       |
| ------- | --------------------- | ------ | ------------------------------ |
| Admin   | Add item to catalogue | Item   | Item is added to the catalogue |
| Admin   | Update item details   | Item   | Item details are updated       |
| Admin   | Sign In               | System | Admin is signed in             |
| Admin   | Sign Out              | System | Admin is signed out            |
| Admin   | Update order status   | Order  | Order status is updated        |
| Admin   | Approve item review   | Review | Review is updated              |

### Customer - Event table

| Subject   | Verb                        | Object  | Response                        |
| --------- | --------------------------- | ------- | ------------------------------- |
| Customer  | Register                    | System  | Customer is registered          |
| Customer  | Sign In                     | System  | Customer is singed in           |
| Customer  | Sign Out                    | System  | Customer is  signed out         |
| Customer  | Add personal details        | System  | Personal details are added      |
| Customer  | Edit personal details       | System  | Personal details are updated    |
| Customer  | Add address                 | System  | Address is added                |
| Customer  | Update address              | System  | Address is updated              |
| Customer  | View item details           | System  | Item details are displayed      |
| Customer  | Add item to the basket      | System  | Item is added to the basket     |
| Customer  | Delete item from the basket | Basket  | Item is deleted from the basket |
| Customer  | Update item quantity        | Basket  | Item quantity is updated        |
| Customer  | Add payment details         | System  | Payment details are added       |
| Customer  | Update payment details      | System  | Payment details are updated     |
| Customer  | View order status           | Order   | Order details are displayed     |
| Customerr | View order history          | Account | Order history is displayed      |
| Customer  | Submit item review          | Item    | Review is submitted for review  |

## Use Case Descriptions

### Admin - Use Case Descriptions

#### Admin - Add item to the catalogue

| Use Case Name        | Add item to the catalogue                                    |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Admin adds item to the catalogue so it will become available to the customers to buy |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Admin                                                        |
| Locations            | Admin portal                                                 |
| Primary pathway      | 1. Admin clicks on add item button<br />2. Admin enters all necessary details<br />3. Details are validated<br />4. Admin presses add button<br />5. Added item is available at customer site |
| Alternate pathways   | Validation fails - message is displayed to the user (depends on the input field and actual input)<br />User presses cancel/back button - user is returned to previous screen (no item is added) |
| Exception pathway    | Database connection fails - error is displayed to the Admin advising of connection problem |


#### Admin - Update item details

| Use Case Name        | Update item details                                          |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Admin updates item details                                   |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Admin                                                        |
| Locations            | Admin portal                                                 |
| Primary pathway      | 1. Admin finds and selects item<br />2. Admin presses edit button<br />3. Non-editable fields are not selectable, only editable fields are available for modification<br />4. Admin updates details   <br />5. Details are validated   <br />6. Admin presses save button <br />7. Item details are updated<br />8. Notification is displayed to the user |
| Alternate pathways   | Validation fails - message is displayed to the user (depends on the input field and actual input)<br />User presses cancel/back button - user is returned to previous screen ( details are not updated) |
| Exception pathway    | Database connection fails - error is<br/>displayed to the Admin advising of connection problem |

#### Admin - Sign In

| Use Case Name        | Sign In                                                      |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Admin signs in                                               |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Admin                                                        |
| Locations            | Admin site                                                   |
| Primary pathway      | 1. Admin goes to admin site URL<br />2. Admin is presented with sign in page<br />3. Admin enters his username and password<br />4. Admin is granted access and is redirected to dashboard |
| Alternate pathways   | Incorrect details are entered – notification is displayed (user name or password are<br/>incorrect) |
| Exception pathway    | Database connection fails - Error displayed to the Admin advising of connection problem |


#### Admin - Sign Out

| Use Case Name        | Sign out                                                     |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Admin signs out                                              |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Admin site                                                   |
| Actor                | Admin                                                        |
| Primary pathway      | 1. Admin clicks on sign out button<br />2. Admin is redirected to login screen<br />3. Notification is displayed confirming logging out |
| Alternate pathways   | None                                                         |
| Exception pathway    | Error occurs - notification is displayed to the user         |

#### Admin - Update order status

| Use Case Name        | Update order status                                          |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Order status is updated (order is picked, packed, shipped, cancelled) |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Admin                                                        |
| Primary pathway      | 1. Admin finds the order<br />2. Admin selects update status order<br />3. Admin updates status order<br />4. Admin presses update<br />5. Order status is changed - customer can see updated order status |
| Alternate pathways   | Admin presses cancel/back button and is returned to previous screen |
| Exception pathway    | Database connection fails - error is displayed to the Admin advising of connection problem |

#### Admin - Approve item review

| Use Case Name        | Approve item review                                          |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Item reviews have to be checked(foul language, spam) and approved by admin in order to be displayed |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Admin                                                        |
| Locations            | Admin site                                                   |
| Primary pathway      | 1. Admin receives notification about pending review<br />2. Admin opens review section of the application<br />3. Admin selects review<br />4. Review is displayed to admin to be checked<br />5. Admin presses approve button<br />6. Review accessible to customers on item page |
| Alternate pathways   | Admin presses reject button - dialogue is displayed with dropdown where reason for rejection can be selected. Notification is displayed to the customer next time he is logged in stating that review has been rejected and reason |
| Exception pathway    | Database connection fails - Error displayed to the Admin advising of connection problem |

### Customer - Use Case Descriptions

#### Customer - Register

| Use Case Name        | Register                                                     |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer registers on the site                               |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer clicks on register button<br />2. Customer is presented with registration form<br />3. Customer fills up required fields<br />4. Entered values are validated<br />5. Customer is shown notification that confirmation email has been sent. |
| Alternate pathways   | Invalid values are entered and validation fails - error message is displayed<br />Confirmation email fails and is not delivered - registration process has to be repeated |
| Exception pathway    | Error occurs - notification is displayed to the user         |