import panda as pd

#Create a DataFrame with the given data
data = {
    "ID": [1, 2, 3, 4, 5],
    "name": ["Laptop", "Mouse", "Keyboard", "Monitor", "Printer"],
    "price": [1000, 20, 50, 200, 150],
    "quantity": [10, 50, 30, 20, 15]
}

df = pd.DataFrame(data)

#Add a new column "total = price * quantity"
df["total"] = df["price"] * df["quantity"]

#Save the data to product.csv
df.to_csv("product.csv", index=False)
print("Data has been saved to product.csv")

#Read the CSV.file
products = pd.read_csv("product.csv")

#Display all products
print("\n---Product Information---")
print(products)

#Display the product with price > 100
print("\n---Products with price > 100---")
expensive_products = products[products["price"] > 100]
if expensive_products.empty:
    print("No products found with price > 100.")
else:
    print(expensive_products)

#Calculate the total inventory value
total_inventory_value = products["total"].sum()
print("\n---Total Inventory Value---")
print(f"Total Inventory Value: ${total_inventory_value:.2f}")