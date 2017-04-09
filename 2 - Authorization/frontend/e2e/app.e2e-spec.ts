import { LegoAppPage } from './app.po';

describe('lego-app App', () => {
  let page: LegoAppPage;

  beforeEach(() => {
    page = new LegoAppPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
