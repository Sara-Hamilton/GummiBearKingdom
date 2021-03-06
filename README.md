# Gummi Bear Kingdom

##### A site for a Gummi Bear Vendor built with Visual Studio MVC, C#, and .NET.  04/20/18

## By Sara Hamilton

# Description
This is the Epicodus weekly project for week 1 of the .NET course.  Its purpose is to display understanding of Visual Studio MVC, ORM, and Migrations.  

## Functionality
### User Stories
* a user can
  * click on a link on the landing page that takes them to a page that lists all available products
  * click on each product and see its details

* an admin can
  * add a product
  * edit a product
  * delete a product
  * delete all products

### Model
  * Product
    * Name
    * Cost
    * Description

## Technologies Used
* HTML
* CSS
* Bootstrap
* Visual Studio
* C#
* .NET
* MySql
* MAMP

## Run the Application  

  * _Clone the github respository_
  ```
  $ git clone https://github.com/Sara-Hamilton/GummiBearKingdom
  ```

  * _Install the .NET Framework and MAMP_

    .NET Core 1.1 SDK (Software Development Kit)

    .NET runtime.

    MAMP

    See https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c for instructions and links.

* _Start the Apache and MySql Servers in MAMP_

 * _Move into the directory_
 ```
 $ cd GummiBearKingdom/GummiBearKingdom
 ```

*  _Setup the database_

  ```
  $ dotnet ef database update
  $ dotnet ef database update 20180420190206_ComplexDataModel2
  ```
*  _Run the program_
  ```
  $ dotnet restore
  $ dotnet run
  ```


### License

*MIT License*

Copyright (c) 2018 **_Sara Hamilton_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
