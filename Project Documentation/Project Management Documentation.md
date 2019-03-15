# Project Management

[TOC]





## Specification of a system component

System component chosen is OrderService which is responsible for creating and fetching orders, this component will be created using Unit of Work and repository design patterns. OrderService uses number of repositories (which abstract database access) to manage in memory collection of objects and any changes written do database together as one unit, hence the name unit of work. Either all operations succeed or fail. Repositories will be implemented with their corresponding interfaces for repository specific operations together with inheriting from generic repository class which contains generic methods for common operations on the generic type. Generic type will be replaced by concrete type -entity, when inheriting from generic repository class. This will help with reusability as there will no longer be need to create separate collection class for each type together with stored procedures which are very similar for common operations such as select, create, update, delete.

## Event Tables

### Admin - Event table

| Subject | Verb                                      | Object    | Response                                       |
| ------- | ----------------------------------------- | --------- | ---------------------------------------------- |
| Admin   | Add item to catalog                       | Item      | Item is added to the catalogue                 |
| Admin   | Update item details                       | Item      | Item details are updated                       |
| Admin   | Sign In                                   | System    | Admin is signed in                             |
| Admin   | Sign Out                                  | System    | Admin is signed out                            |
| Admin   | Approve item review                       | Review    | Review is updated                              |
| Admin   | Add Employee                              | Employee  | Employee is added                              |
| Admin   | Change employee password                  | Employee  | Employee password is changed                   |
| Admin   | Employee change employee task permissions | Employee  | Employee task permissions are changed          |
| Admin   | View Warehouse locations                  | Locations | Warehouse locations are displayed              |
| Admin   | Search warehouse locations                | Locations | Warehouse locations are filtered and displayed |
| Admin   | Add warehouse locations                   | Locations | Warehouse locations are added                  |
| Admin   | View Warehouse locations items            | Locations | Warehouse locations items are displayed        |

### Customer - Event table

| Subject  | Verb                            | Object  | Response                               |
| -------- | ------------------------------- | ------- | -------------------------------------- |
| Customer | Sign Up                         | System  | Customer is registered                 |
| Customer | Sign In                         | System  | Customer is singed in                  |
| Customer | Sign Out                        | System  | Customer is  signed out                |
| Customer | Edit Login and Security details | System  | Login and security details are changed |
| Customer | Add address                     | System  | Address is added                       |
| Customer | Update address                  | System  | Address is updated                     |
| Customer | View item details               | System  | Item details are displayed             |
| Customer | Add item to the basket          | System  | Item is added to the basket            |
| Customer | Delete item from the basket     | Basket  | Item is deleted from the basket        |
| Customer | Update item quantity            | Basket  | Item quantity is updated               |
| Customer | Add payment details             | System  | Payment details are added              |
| Customer | Update payment details          | System  | Payment details are updated            |
| Customer | View order details              | Order   | Order details are displayed            |
| Customer | View order history              | Account | Order history is displayed             |
| Customer | Submit item review              | Item    | Review is submitted for review         |

### Employee - Event table

| Subject  | Verb                        | Object   | Response                                    |
| -------- | --------------------------- | -------- | ------------------------------------------- |
| Employee | Sign In                     | System   | Employee is Singed In.                      |
| Employee | Sing Out                    | System   | Employee is Signed Out.                     |
| Employee | Receive                     | Item     | Item is received into receive location.     |
| Employee | Stow                        | Item     | Item is stowed into a storage location.     |
| Employee | Pick                        | Order    | Order is picked from a storage location.    |
| Employee | Drop into packing location  | Order    | Picked orders are added to a pack location. |
| Employee | Pack                        | Order    | Order is packed and shipment is created.    |
| Employee | Drop into shipping location | Shipment | Shipment is added to a shipping location.   |
| Employee | Dispatch shipment           | Shipment | Shipment is dispatched.                     |

## Use Case Descriptions

### Admin - Use Case Descriptions

#### Admin - Add item to the catalogue

| Use Case Name        | Add item to the catalog                                      |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Admin adds item to the catalog so it will become available to the customers to buy |
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

#### Admin - Add Employee

| Use Case Name        | Add employee                                                 |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Admin adds employee                                          |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Admin                                                        |
| Locations            | Admin site                                                   |
| Primary pathway      | 1. Admin signs in and navigates to add employee page<br />2. Admin is presented with a form with employee details and tasks checkboxes<br />3. Admin fills up details and presses Add employee<br />4. Employee is added and notification is displayed |
| Alternate pathways   |                                                              |
| Exception pathway    | Database connection fails - Error displayed to the Admin advising of connection problem |

#### Admin - Change employee task permisions

| Use Case Name        | Change employee task permissions                             |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Admin changes employee task permissions                      |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Admin                                                        |
| Locations            | Admin site                                                   |
| Primary pathway      | 1. Admin signs in and navigates to view employees page<br /> 2. Admin presses edit details on the chosen employee row <br />3. Admin is presented with employee details <br />4. Admin checks or unchecks checkboxes for corresponding employee tasks<br />5. Admin presses Update employee info button and changes are saved |
| Alternate pathways   |                                                              |
| Exception pathway    | Database connection fails - Error displayed to the Admin advising of connection problem |

#### Admin - Change Employee password

| Use Case Name        | Change employee password                                     |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Admin changes employee password                              |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Admin                                                        |
| Locations            | Admin site                                                   |
| Primary pathway      | 1. Admin signs in and navigates to view employees page<br />2. Admin presses edit details on the chosen employee row<br />3. Admin is presented with employee details and change password button<br />4. Admin presses reset password button and modal with new password and confirm password is displayed<br />5. After entering matching passwords, admin presses update password<br />6. Password is udated |
| Alternate pathways   |                                                              |
| Exception pathway    | Database connection fails - Error displayed to the Admin advising of connection problem |

#### Admin - View warehouse locations

| Use Case Name        | View warehouse locations                                     |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Admin views warehouse locations                              |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Admin                                                        |
| Locations            | Admin site                                                   |
| Primary pathway      | 1. Admin signs in and navigates to view locations page<br />2. All warehouse location are displayed |
| Alternate pathways   |                                                              |
| Exception pathway    | Database connection fails - Error displayed to the Admin advising of connection problem |

#### Admin - Search warehouse locations

| Use Case Name        | Search warehouse locations                                   |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Admin searches warehouse locations                           |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Admin                                                        |
| Locations            | Admin site                                                   |
| Primary pathway      | 1. Admin signs in and navigates to view locations page<br />2. Admin enters whole or part of location id into the search box<br />3. Admin presses search and matched locations are displayed |
| Alternate pathways   |                                                              |
| Exception pathway    | Database connection fails - Error displayed to the Admin advising of connection problem |

#### Admin - Add warehouse locations

| Use Case Name        | Add warehouse locations                                      |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Admin adds warehouse locations                               |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Admin                                                        |
| Locations            | Admin site                                                   |
| Primary pathway      | 1. Admin signs in and navigates to add locations page<br />2. Admin add aisle number number of location and location number start<br />3. Admin presses add locations button.<br />4. Locations are added |
| Alternate pathways   | Aisle is already present - error message is displayed        |
| Exception pathway    | Database connection fails - Error displayed to the Admin advising of connection problem |

#### Admin - View warehouse location items

| Use Case Name        | View warehouse location items                                |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Admin views items in the location                            |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Admin                                                        |
| Locations            | Admin site                                                   |
| Primary pathway      | 1. Admin signs in and navigates to view locations page<br />2. Admin clicks on view location items button<br />3. Items present in the location are displayed |
| Alternate pathways   |                                                              |
| Exception pathway    | Database connection fails - Error displayed to the Admin advising of connection problem |

### Customer - Use Case Descriptions

#### Customer - Register

| Use Case Name        | Sign Up                                                      |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer registers on the site                               |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer clicks on register button<br />2. Customer is presented with registration form<br />3. Customer fills up required fields<br />4. Entered values are validated<br />5. Customer is shown notification that confirmation email has been sent. |
| Alternate pathways   | Invalid values are entered and validation fails - error message is displayed<br />Confirmation email fails and is not delivered - registration process has to be repeated |
| Exception pathway    | Error occurs - notification is displayed to the user         |

#### Customer - Sign in

| Use Case Name        | Sign In                                                      |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer signs in                                            |
| Use Case Author      | Martin Kovac                                                 |
| Actor                | Customer                                                     |
| Locations            | Customer site                                                |
| Primary pathway      | 1. Customer goes to customer site homepage URL<br />2. Customer clicks on sign in button<br />3. Customer is presented with sign in page<br />4. Customer enters his username and password <br />4. Customer is signed in. |
| Alternate pathways   | Incorrect details are entered – notification is displayed (user name or password are incorrect) |
| Exception pathway    | Database connection fails - Error displayed to the Admin advising of connection problem |

#### Customer - Sign out

| Use Case Name        | Sign out                                                     |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer signs out                                           |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer clicks on sign out button <br />2. Notification is displayed confirming the action <br />3. Customer is redirected to homepage without access to their account and sign in button is visible |
| Alternate pathways   | None                                                         |
| Exception pathway    | Error occurs - notification is displayed to the user         |

#### Customer - Edit Login and Security details

| Use Case Name        | Edit Login and Security details                              |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer edits login and security details                    |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer signs in<br />2. Customer goes to Account -> Login & Security<br />3. Customer presses edit on (Name, Email, Phone Number, Password)<br />4. Customer changes selected details<br />5. Customer presses save<br />6. Changes are saved |
| Alternate pathways   | Validation fails - customer is presented with error message  |
| Exception pathway    | Database connection fails - Error displayed to the Customer advising of connection problem |

#### Customer - Add address

| Use Case Name        |                                                              |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description |                                                              |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      |                                                              |
| Alternate pathways   |                                                              |
| Exception pathway    | Database connection fails - Error displayed to the Customer advising of connection problem |

#### Customer - Update address

| Use Case Name        | Update address                                               |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer updates address details                             |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer signs in<br />2. Customer navigates to account page<br />3. Customer selects address and presses edit<br />4. Customer enters details that should be updated<br />5. Details are validated<br />6. Customer clicks update<br />7. Details are updated and notification is displayed to the customer about successfully updating address details |
| Alternate pathways   | Validation fails - error message is displayed to the customer<br />Customer clicks cancel/back button and is returned to the previous page (account page) |
| Exception pathway    | Database connection fails - Error displayed to the Customer advising of connection problem |

#### Customer - View item details

| Use Case Name        | View item details                                            |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer views item details                                  |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer clicks on desired category<br />2. Customer clicks on desired item<br />3. Customer is presented with item page displaying item details |
| Alternate pathways   | None                                                         |
| Exception pathway    | Database connection fails - Error displayed to the Customer advising of connection problem |

#### Customer - Add item to the basket

| Use Case Name        | Add item to the basket                                       |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer add item to the basket                              |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer clicks on desired category<br />2. Customer clicks on desired item<br />3. Customer clicks on add to basket button<br />4. Item is added to the basket, notification is displayed confirming addition of item to the basket and basket icon is updated to indicate quantity of items in the basket. |
| Alternate pathways   | Item are not available - notification is displayed to the user |
| Exception pathway    | Database connection fails - Error displayed to the Customer advising of connection problem |

#### Customer - Update item quantity in the basket

| Use Case Name        | Update item quantity in the basket                           |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer updates/adjusts item quantity in the basket         |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Click on the basket<br />2. Basket content is displayed<br />3. Customer can click on + and - signs buttons to increase or decrease quantity or enter number directly in the textbox<br />4. Quantity is updated when + or - buttons are clicked or textbox goes out of focus |
| Alternate pathways   | No items in the basket - quantity cannot be adjusted unless there is at least one item in the basket |
| Exception pathway    | Database connection fails - Error displayed to the Customer advising of connection problem |



#### Customer - Add payment option

| Use Case Name        | Add payment option                                           |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer adds payment optoion                                |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer signs in<br />2. Customer navigates to account page<br />3. Customer clicks on payment options<br />4. Customer clicks add payment option<br />5. Customer fills out details<br />6. Customer clicks save<br />7. Payment option is added and notification is displayed |
| Alternate pathways   | Validation fails - message is displayed                      |
| Exception pathway    | Database connection fails - Error displayed to the Customer advising of connection problem |

#### Customer - Update payment details

| Use Case Name        | Update payment details                                       |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer updates payment details                             |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer signs in<br />2. Customer navigates to account page<br />3. Customer clicks on payment options<br />4. Customer is presented with payment options<br />5. Customer clicks edit on the chosen payment option<br />6. After changing payment option details customer clicks save<br />7. Payment option is updated and notification is displayed to the customer |
| Alternate pathways   | Validation fails - message is displayed                      |
| Exception pathway    | Database connection fails - Error displayed to the Customer advising of connection problem |

#### Customer - Delete payment details

| Use Case Name        | Delete payment details                                       |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer deletes his/hers payment details                    |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer signs in<br />2. Customer navigates to account page<br />3. Customer clicks on payment options<br />4. Customer is presented with list of his/hers payment options<br />5. Customer clicks delete on chosen payment option.<br />6. Payment option is deleted and notification is displayed.<br /> |
| Alternate pathways   | No payment options present - nothing to delete               |
| Exception pathway    | Database connection fails - Error displayed to the Customer advising of connection problem |

#### Customer - View order details

| Use Case Name        | View order details                                           |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer selects and views order details                     |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer signs in<br />2. Customer navigates to account page<br />3. Customer clicks on orders<br />4. Orders are listed in chronological order<br />5. Customer clicks on the desired order<br />6. Customer is presented with single order page with order details displayed |
| Alternate pathways   | None                                                         |
| Exception pathway    | Database connection fails - Error displayed to the Customer advising of connection problem |

#### Customer - View order history

| Use Case Name        | View order history                                           |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer view their order history                            |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer signs in<br />2. Customer navigates to account page<br />3. Customer clicks on orders<br />4. Customer is presented with their order history - list of previous orders in chronological order |
| Alternate pathways   | If there are no orders - page is empty with message no orders placed |
| Exception pathway    | Database connection fails - Error displayed to the Customer advising of connection problem |

#### Customer - Submit item review

| Use Case Name        | Submit item review                                           |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Customer submits review for purchased items                  |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Customer site                                                |
| Actor                | Customer                                                     |
| Primary pathway      | 1. Customer signs in<br />2. Customer navigates to account page<br />3. Customer clicks on orders<br />4. Customer clicks on write review<br />5. Customer writes review<br />6. Customer presses submit button<br />7. Review is submitted for approval by administrator |
| Alternate pathways   |                                                              |
| Exception pathway    | Database connection fails - Error displayed to the Customer advising of connection problem |

### Employee Use Case Descriptions

#### Employee - Sign In

| Use Case Name        | Sign In                                                      |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Employee sings in                                            |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Warehouse application                                        |
| Actor                | Employee                                                     |
| Primary pathway      | 1. Employee enters his/hers username and password<br />2. Employee is presented with main form |
| Alternate pathways   | Wrong credentials entered - error message is displayed       |
| Exception pathway    | Database connection fails                                    |

#### Employee - Sign Out

| Use Case Name        | Employee sing out                                            |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Employee signs out of the application                        |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Warehouse application                                        |
| Actor                | Employee                                                     |
| Primary pathway      | 1. Employee presses sign out button on the main form<br />2. Employee is presented with a sign in form |
| Alternate pathways   | None                                                         |
| Exception pathway    |                                                              |

#### Employee - Receive item

| Use Case Name        | Receive Item                                                 |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Employee receives item                                       |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Warehouse application                                        |
| Actor                | Employee                                                     |
| Primary pathway      | 1. Employee opens application and signs in<br />2. Employee chooses receive<br />3. Employee scans item barcode<br />4. Employee enters quantity<br />5. Employee click on receive<br />6. Item is received |
| Alternate pathways   | Item barcode is not recognized by the system - employee sidelines item |
| Exception pathway    | Database connection fails                                    |

#### Employee - Stow Item

| Use Case Name        | Stow item                                                    |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Employee stows item into the location                        |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Warehouse application                                        |
| Actor                | Employee                                                     |
| Primary pathway      | 1. Employee opens application and signs in<br />2. Employee chooses stow<br />3. Employee picks item from ready to stow location<br />4. Employee finds suitable warehouse location and scans it<br />5. Employee scans item<br />6. Employee enters quantity<br />7. Employee presses stow.<br />8. Item is added to location. |
| Alternate pathways   | Item barcode is not recognized/ location id is not recognized - sideline item. retry scanning location |
| Exception pathway    | Database connection fails                                    |

#### Employee - Pick customer order

| Use Case Name        | Pick Customer order                                          |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Employee pick customer order from a warehouse location       |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Warehouse application                                        |
| Actor                | Employee                                                     |
| Primary pathway      | 1. Employee signs in<br />2. Employee presses pick button<br />3. Employee is presented with information about the location and description of the order item<br />4. Employee finds location and the item and scans item.<br />5. Employee presses pick item.<br />6. Item is moved to employee pick container.<br />7. When ready employee presses finish picking and items are moved into ready to pack location |
| Alternate pathways   | Item is not found, Item barcode is not recognized            |
| Exception pathway    | Database connection fails                                    |



#### Employee - Pack order

| Use Case Name        | Pack order                                                   |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Employee pack order                                          |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Warehouse application                                        |
| Actor                | Employee                                                     |
| Primary pathway      | 1. Employee signs in<br />2. Employee presses pack button<br />3. Employee takes item from ready to pack location<br />4. Employee scans item barcode.<br />5. Employee packs item and presses print shipping label<br />6. Employee stick shipping label on the package<br />7. When ready employee presses finish packing<br />8. Items are moved into ready to ship location |
| Alternate pathways   | Printer fails, barcode is not recognized by the system       |
| Exception pathway    | Database connection fails                                    |



#### Employee - Dispatch order

| Use Case Name        | Ship order                                                   |
| -------------------- | ------------------------------------------------------------ |
| Use Case Description | Employee ships packed order                                  |
| Use Case Author      | Martin Kovac                                                 |
| Locations            | Warehouse application                                        |
| Actor                | Employee                                                     |
| Primary pathway      | 1. Employee signs in<br />2. Employee presses ship button<br />3. Employee scans shipping label on the package<br />4. Employee loads package on trailer/lorry<br />5. Employee presses dispatch item<br />6. Order is marked as completed.<br /> |
| Alternate pathways   | Shipping label is not recognized,                            |
| Exception pathway    | Database connection fails                                    |
