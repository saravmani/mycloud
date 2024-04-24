
Backup Center
Recovery Services vault
Microsoft Azure Recovery Services (MARS)  Agent helps for backup



#### Recovery Services vault
  - Backups are stored in an Azure Recovery Services vault
  - built-in management of recovery points
  - In the Azure portal, you can create a Recovery Services vault from the Backup center dashboard.
  - Within an Azure subscription, you can create up to 500 Recovery Services vaults per region.
  - It can take several minutes to create the Recovery Services vault.






#### My understanding
Backup components should be installed on the devices (on-promise or azure).
(there may be multiple different varities of backup components specific to need)
And thise components are used to take backup data to Recovery services vault in Aure

Backups are stored in an Azure Recovery Services vault

Azure Backup doesn't limit the amount of inbound or outbound data you transfer, or charge for the data that's transferred.


Data encryption allows for secure transmission and storage of your data in the public cloud. You store the encryption passphrase locally, and it's never transmitted or stored in Azure. If it's necessary to restore any of the data, only you have encryption passphrase, or key.
