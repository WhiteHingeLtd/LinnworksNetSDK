using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IInventoryController
	{
		AddImageToInventoryItemResponse AddImageToInventoryItem(AddImageToInventoryItemRequest request);
		string AddInventoryItem(StockItem inventoryItem);
		void AddItemLocations(List<StockItemLocation> itemLocations);
		void AddProductIdentifiers(AddProductIdentifiersRequest request);
		AddScrapCategoriesResponse AddScrapCategories(AddScrapCategoriesRequest request);
		AddScrapItemResponse AddScrapItem(AddScrapItemRequest request);
		Supplier AddSupplier(Supplier supplier);
		void AdjustEbayTemplatesInstantLMS(IEnumerable<Guid> inventoryItemIds,String subSource,String siteId,AdjustmentOptions adjustmentOptions);
		void AdjustTemplatesInstant(IEnumerable<Guid> inventoryItemIds,String source,String subSource,AdjustmentOptions adjustmentOptions);
		void ArchiveInventoryItems(InventoryParametersRequest parameters);
		void BulkScrapBatchedItems(BulkScrapBatchedItemsRequest request);
		void CreateBatches(IEnumerable<StockItemBatch> batches);
		Category CreateCategory(String categoryName);
		void CreateCountries(IEnumerable<Country> countries);
		CreateCountryRegionsResponse CreateCountryRegions(CreateCountryRegionsRequest request);
		void CreateInventoryItemChannelSKUs(List<StockItemChannelSKU> inventoryItemChannelSKUs);
		void CreateInventoryItemCompositions(List<StockItemComposition> inventoryItemCompositions);
		void CreateInventoryItemDescriptions(List<StockItemDescription> inventoryItemDescriptions);
		void CreateInventoryItemExtendedProperties(List<StockItemExtendedPropertyUpsertItem> inventoryItemExtendedProperties);
		void CreateInventoryItemPrices(List<StockItemPrice> inventoryItemPrices);
		void CreateInventoryItemPricingRules(List<StockItemPricingRule> rules);
		void CreateInventoryItemTitles(List<StockItemTitle> inventoryItemTitles);
		void CreateStockSupplierStat(List<StockItemSupplierStat> itemSuppliers);
		void CreateUserSpecificView(InventoryView view);
		void DeleteBatchesByStockItemId(Guid stockItemId);
		void DeleteBatchInventoryInBulk(IEnumerable<Int32> batchInventoryIds);
		void DeleteCategoryById(Guid categoryId);
		void DeleteCountries(IEnumerable<Guid> countriesIds);
		DeleteEbayCompatibilityListResponse DeleteEbayCompatibilityList(DeleteEbayCompatibilityListRequest request);
		void DeleteImagesFromInventoryItem(Dictionary<Guid,List<String>> inventoryItemImages);
		void DeleteInventoryItemChannelSKUs(List<Guid> inventoryItemChannelSKUIds);
		void DeleteInventoryItemCompositions(Guid stockItemId,List<Guid> inventoryItemCompositionIds);
		void DeleteInventoryItemDescriptions(List<Guid> inventoryItemDescriptionIds);
		void DeleteInventoryItemExtendedProperties(Guid inventoryItemId,List<Guid> inventoryItemExtendedPropertyIds);
		void DeleteInventoryItemPrices(List<Guid> inventoryItemPriceIds);
		void DeleteInventoryItemPricingRules(List<Int32> pricingRuleIds);
		void DeleteInventoryItems(DeleteInventoryItemsRequest request,List<Guid> inventoryItemIds);
		void DeleteInventoryItemTitles(List<Guid> inventoryItemTitleIds);
		void DeleteItemLocations(Guid inventoryItemId,List<Guid> itemLocations);
		void DeleteProductIdentifiers(DeleteProductIdentifiersRequest request);
		void DeleteScrapCategories(DeleteScrapCategoriesRequest request);
		void DeleteStockSupplierStat(Guid stockItemId,List<Guid> itemSupplierIds);
		void DeleteSuppliers(List<Guid> suppliersIds);
		void DeleteUserSpecificView(String viewName);
		void DuplicateInventoryItem(StockItem inventoryItem,Guid sourceItemId,Boolean copyImages);
		Dictionary<String,List<String>> GetAllExtendedPropertyNames();
		GetBatchAuditResponse GetBatchAudit(GetBatchAuditRequest request);
		List<StockItemBatch> GetBatchesByStockItemId(Guid stockItemId,Boolean onlyAvailable);
		GetBatchInventoryByIdResponse GetBatchInventoryById(GetBatchInventoryByIdRequest request);
		List<Category> GetCategories();
		List<AnyConfig> GetChannels();
		List<HeaderConfig> GetChannelsBySource(String source);
		IEnumerable<Country> GetCountries();
		Dictionary<String,String> GetCountryCodes();
		List<StockItemEbayCompatibility> GetEbayCompatibilityList(Guid stockItemId);
		List<String> GetExtendedPropertyNames(String propertyType = "Attribute");
		List<String> GetExtendedPropertyTypes();
		GetImagesInBulkResponse GetImagesInBulk(GetImagesInBulkRequest request);
		Dictionary<String,Byte> GetInventoryBatchTypes();
		List<StockItemAuditTrail> GetInventoryItemAuditTrail(Guid inventoryItemId);
		List<StockItemBatch> GetInventoryItemBatchInformation(GetInventoryItemBatchInformationRequest Request);
		GetInventoryItemBatchInformationByIdsResponse GetInventoryItemBatchInformationByIds(GetInventoryItemBatchInformationByIdsRequest request);
		StockItemInv GetInventoryItemById(Guid id);
		List<StockItemChannelSKU> GetInventoryItemChannelSKUs(Guid inventoryItemId);
		List<StockItemChannelSKUWithLocation> GetInventoryItemChannelSKUsWithLocation(Guid channelSKURowId);
		List<StockItemComposition> GetInventoryItemCompositions(Guid inventoryItemId,Boolean getFullDetail = false);
		List<StockItemDescription> GetInventoryItemDescriptions(Guid inventoryItemId);
		List<StockItemExtendedProperty> GetInventoryItemExtendedProperties(Guid inventoryItemId,GetExtendedPropertyFilter propertyParams);
		List<StockItemImage> GetInventoryItemImages(Guid inventoryItemId);
		List<StockItemLocation> GetInventoryItemLocations(Guid inventoryItemId);
		Dictionary<String,List<String>> GetInventoryItemPriceChannelSuffixes();
		List<StockItemPricingRule> GetInventoryItemPriceRulesById(Guid stockItemPriceId);
		List<StockItemPricingRule> GetInventoryItemPriceRulesBySource(Guid stockItemId,String source,String subSource);
		List<StockItemPrice> GetInventoryItemPrices(Guid inventoryItemId);
		Dictionary<String,List<String>> GetInventoryItemPriceTags();
		GetInventoryItemsCompositionByIdsResponse GetInventoryItemsCompositionByIds(GetInventoryItemsCompositionByIdsRequest request);
		Int32 GetInventoryItemsCount(Boolean? includeDeleted,Boolean? includeArchived);
		List<StockItemTitle> GetInventoryItemTitles(Guid inventoryItemId);
		String GetNewItemNumber();
		List<KeyGuidValue> GetPackageGroups();
		List<KeyGuidValue> GetPostalServices();
		List<InventoryView> GetPreDefinedViews();
		GetProductIdentifiersByStockItemIdResponse GetProductIdentifiersByStockItemId(GetProductIdentifiersByStockItemIdRequest request);
		GetProductIdentifierTypesRequest GetProductIdentifierTypes();
		GetScrapCategoriesResponse GetScrapCategories();
		GetScrapHistoryResponse GetScrapHistory(GetScrapHistoryRequest request);
		GetStockItemBatchesByLocationResponse GetStockItemBatchesByLocation(GetStockItemBatchesByLocationRequest request);
		GetStockItemIdsBySKU GetStockItemIdsBySKU(GetStockItemIdsBySKURequest request);
		List<StockItemLabel> GetStockItemLabels(List<Tuple<Int32,Int32>> selectedRegions,Guid token,Guid location);
		List<InventoryStockLocation> GetStockLocations();
		List<StockItemSupplierStat> GetStockSupplierStat(Guid inventoryItemId);
		Supplier GetSupplierDetails(Guid supplierId);
		List<Supplier> GetSuppliers();
		List<InventoryView> GetUserSpecificViews();
		Boolean HasStockItemBatches(Guid stockItemId);
		HasStockItemStockLevelResponse HasStockItemStockLevel(HasStockItemStockLevelRequest request);
		InsertUpdateEbayCompatibilityListResponse InsertUpdateEbayCompatibilityList(InsertUpdateEbayCompatibilityListRequest request);
		Boolean IsInventoryItemChannelSKULinked(String channelSKU,String source,String subSource);
		Boolean IsOwnedStockLocation(Guid locationId);
		ScrapBatchedItemResponse ScrapBatchedItem(ScrapBatchedItemRequest request);
		void SetInventoryItemImageAsMain(Guid inventoryItemId,Guid mainImageId);
		void UnarchiveInventoryItems(InventoryParametersRequest parameters);
		void UnlinkChannelListing(String channelRefId,String source,String subSource);
		void UpdateBatchDetails(UpdateBatchDetailsRequest request);
		void UpdateBatchesWithInventory(IEnumerable<StockItemBatch> batches);
		void UpdateCategory(Category category);
		Int32 UpdateCompositeParentStockLevel(Guid stockItemId,Guid locationId,Int32 fieldValue);
		void UpdateCountries(IEnumerable<Country> countries);
		void UpdateCountryRegions(UpdateCountryRegionsRequest request);
		void UpdateImages(List<StockItemImageSimple> images);
		void UpdateInventoryItem(StockItemInv inventoryItem);
		void UpdateInventoryItemChannelSKUs(List<StockItemChannelSKU> inventoryItemChannelSKUs);
		void UpdateInventoryItemChannelSKUsWithLocation(List<StockItemChannelSKUWithLocation> inventoryItemChannelSKUsWithLocation);
		void UpdateInventoryItemCompositions(List<StockItemComposition> inventoryItemCompositions);
		void UpdateInventoryItemDescriptions(List<StockItemDescription> inventoryItemDescriptions);
		void UpdateInventoryItemExtendedProperties(List<StockItemExtendedProperty> inventoryItemExtendedProperties);
		Dictionary<String,Object> UpdateInventoryItemField(Guid inventoryItemId,ColumnNameType fieldName,String fieldValue);
		Dictionary<Guid,Dictionary<String,Object>> UpdateInventoryItemLevels(Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,Guid locationId,String changeSource = null);
		Dictionary<String,Object> UpdateInventoryItemLocationField(Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,Guid locationId,String changeSource = null);
		void UpdateInventoryItemPrices(List<StockItemPrice> inventoryItemPrices);
		void UpdateInventoryItemPricingRules(List<StockItemPricingRule> rules);
		Dictionary<String,Object> UpdateInventoryItemStockField(Guid inventoryItemId,ColumnNameType fieldName,String fieldValue,Guid locationId,String changeSource = null);
		void UpdateInventoryItemTitles(List<StockItemTitle> inventoryItemTitles);
		void UpdateItemLocations(List<StockItemLocation> itemLocations);
		void UpdateProductIdentifiers(UpdateProductIdentifiersRequest request);
		void UpdateScrapCategories(UpdateScrapCategoriesRequest request);
		void UpdateStockSupplierStat(List<StockItemSupplierStat> itemSuppliers);
		void UpdateSupplier(Supplier supplier);
		void UpdateUserSpecificView(String viewName,InventoryView view);
		List<PictureSource> UploadImagesToInventoryItem(Guid inventoryItemId,List<Guid> imageIds);
	} 
}