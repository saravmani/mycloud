

await page.getByText("some displayname").click()


test.describe("some group name",()=>{

test.beforeEach(async({page})=>{
// write the code to peform before each test. this will work ONLY within this DESCRIBE. 
// if this BEFOREEACH hook is outside of the descibe then it will work for all the groups and tests within groups
})

})


await page.getByRole('button', { name: 'Sign in' }).click();


expect is the generic assertion. it is basic
if u pass any locator as a paramter for expect method then it will be locator assertion
and we have to async for this
async expect(locatorObj).toHaveText("Expected string").
by default expect having 5 sec timeout. we can increase it by passing timeout value
but for other locator default timeout is 30 sec

soft assertion will not block the next test cases or the flow. but it will reported in report
expect.soft


playwright will create separate worker for each SPEC file and execute them in parallel.
also we can able to execute the tests within single spec file by setting fullyParallel property as true in config file. (within a worker tests will executed in parallel)

by default playwright randomly picks the spec file. if u want to execute them in order the prefix the file with 001-filename.spec.ts, 002.. etc., also configure the workers as 1

test.describe.parallel() // this will  exccute the tests within group in parallel

## Testid for playwright. this is reserved by playwright
data-testid="idname"


## Locator
page.Locator(':text("somepartial text")')
page.Locator(':text-is("full text")')

page.Locator('#id')
page.Locator('.classname')
page.Locator('[attribute=value]')

### join regular locator with user facing locator
page.Locator('div').getByRole("button",{name:'Click Me'})


### filters
page.Locator('div',{hasText:'some text in child dom witin div tag'})

page.Locator('div',{has:page.locator('.childNodeClass')}).getByRole("button",{name:'some text on button'})

page.Locator('div').filter({hasText:'some text in child dom witin div tag'}).filter({hasText:'chain filter'})

## parent element finder
page.Locator('#id').locator('..') //this is one level up. using xPath