using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added.";
        public static string ProductUpdated = "Product Updated.";
        public static string ProductNameInvalid = "Invalid Product Name!";
        public static string ProductsListed = "Products Listed.";
        public static string MaintenanceTime = "System Maintenance";
        public static string ProductCountOfCategoryError = "There are more than 15 products in this category.";
        public static string ProductNameAlreadyExists = "Product name already exists.";
        public static string CategoryLimitExceeded = "Category Limit Exceeded!";
        public static string AuthorizationDenied = "Authorization Denied!";

        public static string UserRegistered = "User Registered.";
        public static string UserNotFound = "User Not Found!";
        public static string PasswordError = "Invalid Password!";
        public static string SuccessfulLogin = "Login Successful.";
        public static string UserAlreadyExists = "User Already Exists!";
        public static string AccessTokenCreated = "AccessTokenCreated";
    }
}