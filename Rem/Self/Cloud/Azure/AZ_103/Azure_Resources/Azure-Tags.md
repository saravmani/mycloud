

Azure Tags are a Name:Value pair

Ex: we can create tag Environment:Prod and assign to all prod resources.

With help of tags we can perform multiple operations in azure env
Ex: Costg analysis, Sutdown all the VMs with specific tag, developers can only update VMs with specific tag etc.,

>***Tags are not inherited***
we can assign this to subscription level also. But it will not get inherited to the resources under the subscription. we have to individual resources and give the tag. But we use azure policy to enfoce to manually add the tags to the resources.
Also we can use azure cli or powershell or commands to automatically add the tags to all the child resources


> *Maximum we can give 50 tags per resource*
