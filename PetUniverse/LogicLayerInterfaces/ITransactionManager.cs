﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObjects;

namespace LogicLayerInterfaces
{

    /// <summary>
    /// Creator: Jaeho Kim
    /// Created: 2/27/2020
    /// Approver: Rasha Mohammed
    /// Interface outlines the requirements for the Transaction Manager class.
    /// </summary>
    public interface ITransactionManager
    {

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/03/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for Selecting all products with a TransactionID.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="transactionID">the transaction id related to the products</param>
        /// <returns>returns a Transaction list</returns>
        List<TransactionVM> RetrieveAllProductsByTransactionID(int transactionID);

        /// <summary>
        /// NAME: Rasha Mohammed
        /// DATE: 2/25/2020
        /// CHECKED BY: Jaeho Kim
        /// 
        /// Interface to delete product from transactionLine when the productID selected.
        /// </summary>
        /// <remarks>
        /// UPDATED BY:
        /// UPDATED DATE: 
        /// CHANGES: 
        /// 
        /// </remarks>
        bool DeleteItem(string productID);

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/17/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for Selecting a product with Product UPC.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="productID">The product upc number</param>
        /// <returns>returns a Transaction</returns>
        ProductVM RetrieveProductByProductID(string productID);

        /// <summary>
        /// CREATOR: Jaeho Kim
        /// DATE: 03/19/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for adding a transaction using transactionID.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="transaction">the transaction object</param>
        /// <returns>bool</returns>
        bool AddTransaction(Transaction transaction);

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/19/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for adding products to a transaction.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="transactionLineProducts"></param>
        /// <returns>returns a Transaction</returns>
        bool AddTransactionLineProducts(TransactionLineProducts transactionLineProducts);

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/19/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for adding a product to 
        /// a list of every products. This method adds every 
        /// product to the list whether the product is 
        /// taxable or not.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="productVM"></param>
        void AddProduct(ProductVM productVM);

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/19/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for adding a taxable product 
        /// to a list of taxable products only.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="productVM"></param>
        void AddProductTaxable(ProductVM productVM);

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/19/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for getting a list
        /// of every products (taxable or not).
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <returns>List of all products</returns>
        List<ProductVM> GetAllProducts();

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/19/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for getting a list
        /// of taxable products only.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <returns>List of all products</returns>
        List<ProductVM> GetTaxableProducts();

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/19/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for getting an 
        /// IEnumerable of every products (taxable or 
        /// not).
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <returns>IEnumerable of All Products</returns>
        IEnumerable<ProductVM> EnumerableAllProducts();

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/19/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for getting an 
        /// IEnumerable of every taxable products.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <returns>IEnumerable of Taxable Products</returns>
        IEnumerable<ProductVM> EnumerableTaxableProducts();

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/19/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for getting 
        /// the latest sales tax date of the zip code.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="zipCode"></param>
        /// <returns>DateTime</returns>
        DateTime RetrieveLatestSalesTaxDateByZipCode(string zipCode);

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/19/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for getting 
        /// the tax rate of the zip code, of the 
        /// latest sales tax date.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="zipCode"></param>
        /// <param name="salesTaxDate"></param>
        /// <returns>sales tax rate</returns>
        decimal RetrieveTaxRateBySalesTaxDateAndZipCode(string zipCode, DateTime salesTaxDate);

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/19/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for calculating 
        /// the sub total of all of the products.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="AllProductsList"></param>
        /// <returns>SubTotal</returns>
        decimal CalculateSubTotal(List<ProductVM> AllProductsList);

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/19/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for calculating 
        /// the sub total of the taxable products.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="TaxableProductList"></param>
        /// <returns>SubTotalTaxable</returns>
        decimal CalculateSubTotalTaxable(List<ProductVM> TaxableProductList);

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/22/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for calculating the 
        /// total of the products. One param Takes the 
        /// subTotal, which represents the cost of all products. 
        /// Another param takes the subTotalTaxable, which 
        /// represents only the cost of taxable products. 
        /// This number is used to calculate the tax.
        /// The final param represents the salesTax object. 
        /// Only the taxRate is actually used for calculation.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="salesTax"></param>
        /// <param name="subTotal"></param>
        /// <param name="subTotalTaxable"></param>
        /// <returns>Total</returns>
        decimal CalculateTotal(decimal subTotal, decimal subTotalTaxable, SalesTax salesTax);

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/22/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for validating the
        /// item quantity.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="productVM"></param>
        /// <param name="shoppingCart"></param>
        /// <returns>bool</returns>
        bool isItemQuantityValid(List<ProductVM> shoppingCart, ProductVM productVM);

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 04/04/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for clearing the shopping cart.
        /// item quantity.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <returns>bool</returns>
        void ClearShoppingCart();

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/07/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for Selecting all Transactions with a TransactionDate.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="transactionDate"></param>
        /// <returns>returns a Transaction list</returns>
        List<TransactionVM> RetrieveTransactionByTransactionDate(DateTime transactionDate);

        /// <summary>
        /// Creator: Jaeho Kim
        /// Created: 03/08/2020
        /// Approver: Rasha Mohammed
        ///
        /// Interface method signature for Selecting all Transactions with a Employee Name.
        /// </summary>
        /// <remarks>
        /// Updater: NA
        /// Updated: NA
        /// Update: NA
        /// </remarks>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>returns a Transaction</returns>
        List<TransactionVM> RetrieveTransactionByEmployeeName(string firstName, string lastName);
    }
}
