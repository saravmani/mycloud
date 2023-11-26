
  Only the hot and cool access tiers can be set at the account level. The archive access tier can only be set at the blob level.

##### The lifecycle management policy lets you:
  - Transition blobs to a cooler storage tier (hot to cool, hot to archive, or cool to archive) to optimize for performance and cost
  - Delete blobs at the end of their lifecycles
  - Define rules to be run once per day at the storage account level
  - Apply rules to containers or a subset of blobs (using prefixes as filters)


  At least one rule is required in a policy. You can define up to 100 rules in a policy.



  ### Sample Policy
  Tier blob to cool tier 30 days after last modification
  Tier blob to archive tier 90 days after last modification
  Delete blob 2,555 days (seven years) after last modification
  Delete blob snapshots 90 days after snapshot creation.


  ```json
  {
    "rules": [
      {
        "name": "ruleFoo",
        "enabled": true,
        "type": "Lifecycle",
        "definition": {
          "filters": {
            "blobTypes": [ "blockBlob" ],
            "prefixMatch": [ "container1/foo" ]
          },
          "actions": {
            "baseBlob": {
              "tierToCool": { "daysAfterModificationGreaterThan": 30 },
              "tierToArchive": { "daysAfterModificationGreaterThan": 90 },
              "delete": { "daysAfterModificationGreaterThan": 2555 }
            },
            "snapshot": {
              "delete": { "daysAfterCreationGreaterThan": 90 }
            }
          }
        }
      }
    ]
  }
  ```
  ---


  If you define more than one action on the same blob, lifecycle management applies the least expensive action to the blob. For example, action delete is cheaper than action tierToArchive. Action tierToArchive is cheaper than action tierToCool.

  ---
