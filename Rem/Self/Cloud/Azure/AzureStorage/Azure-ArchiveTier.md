

## Rehydrate blob data from the archive tier

##### Two options for rehydrating
1. Copy an archived blob to an online tier: rehydrate by copying it to a new blob in the hot or cool tier with the Copy Blob or Copy Blob from URL operation. Microsoft recommends this option for most scenarios.

2. Change a blob's access tier to an online tier


#### Rehydration priority

1. Standard priority: Rehydration request is processed in the order it was received and might take up to 15 hours.

2. High priority: Rehydration request is prioritized over standard priority requests and might complete in under one hour for objects under 10 GB in size.
3. you can set the priority for the rehydration operation via the optional x-ms-rehydrate-priority header on a Set Blob Tier


#### Copy an archived blob to an online tier
- You can use either the Copy Blob or Copy Blob from URL operation to copy the blob.
- When you copy an archived blob to a new blob in an online tier, the source blob remains unmodified in the archive tier.
- You must copy the archived blob to a new blob with a different name or to a different container.
- Copying an archived blob to an online destination tier is supported within the same storage account only. You can't copy an archived blob to a destination blob that is also in the archive tier


**Note:**
- Changing a blob's tier doesn't affect its Last Modified time.
- If there is a lifecycle management policy in effect for the storage account, then rehydrating a blob with Set Blob Tier can result in a scenario where the lifecycle policy moves the blob back to the archive tier after rehydration, because the last modified time is beyond the threshold set for the policy :-) ` So we should be careful here`
