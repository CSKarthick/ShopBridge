IF NOT EXISTS (SELECT * FROM master.sys.databases 
          WHERE name='ShopBridge')
BEGIN
CREATE DATABASE ShopBridge
END