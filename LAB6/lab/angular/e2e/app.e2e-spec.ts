import { LABTemplatePage } from './app.po';

describe('LAB App', function() {
  let page: LABTemplatePage;

  beforeEach(() => {
    page = new LABTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
